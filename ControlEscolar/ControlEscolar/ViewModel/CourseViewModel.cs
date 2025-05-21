using ControlEscolar.Model;
using ControlEscolar.Repositories;
using ControlEscolar.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace ControlEscolar.ViewModel
{
    public class CourseViewModel : ViewModelBase
    {
        private readonly CourseRepository cursoRepository;

        public List<CourseModel> ListaCursos { get; set; }
    
        public ObservableCollection<MateriaModel> Materias { get; set; }
        public ObservableCollection<MaestroModel> Maestros { get; set; }
        public ICommand CreateCourseCommand { get; }

        public CourseModel NewCourse { get; set; } = new CourseModel();


        public CourseViewModel()
        {
            cursoRepository = new CourseRepository();
            Materias = new ObservableCollection<MateriaModel>(cursoRepository.ObtenerMaterias());
            Maestros = new ObservableCollection<MaestroModel>(cursoRepository.ObtenerMaestros());
            CreateCourseCommand = new ViewModelCommand(ExecuteCreateCourseCommand, CanExecuteCreateCourseCommand);
        }
        private int _selectedMateriaID;
        public int SelectedMateriaID
        {
            get => _selectedMateriaID;
            set
            {
                _selectedMateriaID = value;
                OnPropertyChanged(nameof(SelectedMateriaID));
            }
        }

        private int _selectedProfesorID;
        public int SelectedProfesorID
        {
            get => _selectedProfesorID;
            set
            {
                _selectedProfesorID = value;
                OnPropertyChanged(nameof(SelectedProfesorID));
            }
        }
        private string _horaInicio;
        public string HoraInicio
        {
            get => _horaInicio;
            set
            {
                _horaInicio = value;
                OnPropertyChanged(nameof(HoraInicio));
            }
        }

        private string _horaFin;
        public string HoraFin
        {
            get => _horaFin;
            set
            {
                _horaFin = value;
                OnPropertyChanged(nameof(HoraFin));
            }
        }
        private int _grado;
        public int Grado
        {
            get => _grado;
            set
            {
                _grado = value;
                OnPropertyChanged(nameof(Grado));
            }
        }

        private string _grupo;
        public string Grupo
        {
            get => _grupo;
            set
            {
                _grupo = value;
                OnPropertyChanged(nameof(Grupo));
            }
        }
        private string _dia ;
        public string Dia
        {
            get => _dia;
            set
            {
                _dia = value;
                OnPropertyChanged(nameof(Dia)); 
            }
        }

        public List<string> HorasDisponibles { get; set; } = new List<string>
        {
            "07:30", "10:00", "12:00", "14:00"
        };
        public List<string> DiasDisponibles { get; set; } = new List<string>
        {
            "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"
        };

        private void ExecuteCreateCourseCommand(object obj)
        {
            NewCourse.MateriaID = SelectedMateriaID;
            NewCourse.Numero_Empleado = SelectedProfesorID;
            NewCourse.Dia = Dia; // 🔥 Asegurar que `NewCourse` reciba el valor seleccionado en `ComboBox`
            MessageBox.Show($"Día seleccionado en ViewModel: {NewCourse.Dia ?? "NULO"}");

            if (string.IsNullOrEmpty(NewCourse.Dia?.Trim())) // 🔥 Agregar `?` para evitar posibles `null`
            {
                MessageBox.Show("Por favor, selecciona un día antes de continuar.");
                return;
            }

            if (!int.TryParse(Grado.ToString(), out int grado) || grado < 1 || grado > 9)
            {
                MessageBox.Show("❌ Error: Por favor, ingresa un número válido para el grado (1-9).", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            NewCourse.Grado = grado;

            if (string.IsNullOrWhiteSpace(Grupo) || !Regex.IsMatch(Grupo, "^[A-E]$"))
            {
                MessageBox.Show("❌ Error: Por favor, ingresa solo una letra mayúscula para el grupo (A-E).", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            NewCourse.Grupo = Grupo[0]; // 🔥 Tomamos solo el primer carácter
            NewCourse.HoraInicio = TimeSpan.TryParse(HoraInicio, out TimeSpan horaInicio) ? horaInicio : TimeSpan.Zero;
            NewCourse.HoraFin = TimeSpan.TryParse(HoraFin, out TimeSpan horaFin) ? horaFin : TimeSpan.Zero;


            if (NewCourse.MateriaID == 0 || NewCourse.Numero_Empleado == 0)
            {
                MessageBox.Show("Seleccione una materia y un profesor.");
                return;
            }

            bool isInserted = cursoRepository.GuardarCurso(NewCourse);
            MessageBox.Show(isInserted ? "Curso registrado con éxito." : "Error al registrar el curso.");
        }



        private bool CanExecuteCreateCourseCommand(object parameter)
        {
            return true;/*NewCourse.MateriaID > 0
                && NewCourse.Numero_Empleado > 0
                && NewCourse.Grado > 0
                && !string.IsNullOrWhiteSpace(NewCourse.Dia)
                && NewCourse.HoraInicio != default
                && NewCourse.HoraFin != default;*/
        }
    }
}


