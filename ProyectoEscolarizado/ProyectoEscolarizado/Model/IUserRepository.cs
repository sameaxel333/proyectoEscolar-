﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEscolarizado.Model
{
   public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);

        void Add(UserModel userModel);

        void Edit(UserModel userModel);

        void Remove(int id );

        UserModel GetByID(int id);

        UserModel GetByUsername(string username);


    }
}
