﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seguridad.Listas;
using System.Data.Odbc;

namespace Seguridad
{
  public  class Funciones
    {
        public static int InsertarPerfil(Perfiles add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into perfil values('{0}','{1}')", add.id_Perfil, add.descrip_Perfil), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {

                return retorno;
            }
            
        }

        public static int InsertarApp(Aplicaciones add)
        {
            int retorno = 0;
            try
            {
               OdbcCommand comando = new OdbcCommand(String.Format("INSERT into aplicaciones_encabezado values('{0}','{1}')", add.id_App, add.descrip_App), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
            
        }
        public static List<Aplicaciones> MostarApp ()
        {
            List<Aplicaciones> App = new List<Aplicaciones>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from aplicaciones_encabezado;"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Aplicaciones api = new Aplicaciones();
                api.id_App = reader.GetInt32(0);
                api.descrip_App = reader.GetString(1);
              App.Add(api);
            }
            return App;
        }
        public static List<Perfiles> MostarPerfiles()
        {
            List<Perfiles> Per = new List<Perfiles>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from perfil;"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Perfiles perf = new Perfiles();
                perf.id_Perfil= reader.GetInt32(0);
                perf.descrip_Perfil = reader.GetString(1);
                Per.Add(perf);
            }
            return Per;
        }
        public static int InsertarAppDetalle(AppDetalle add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into aplicaciones_detalle values('{0}','{1}','{2}','{3}','{4}')", add.id_Perfil, add.id_app, add.create, add.update,add.delete), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }

        }

        public static bool IngresoSesion(string usuario, string pswd)
        {
           
                OdbcCommand comando = new OdbcCommand(String.Format("Select * from usuarios where nickname_Usuario = '{0}' and pswd_Usuario ='{1}'", usuario, pswd), Conexion.getDB());
                OdbcDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {

                    return true;
            }else
            {
                return false;
            }
            
        }

        public static int IngresoUsuario(Usuarios add)
        {
            int retorno = 0;
            try
            {
                OdbcCommand comando = new OdbcCommand(String.Format("INSERT into usuarios(nombre_usuario,apellido_usuario,telefono_usuario,correo_usuario,nickname_usuario,pswd_usuario) values('{0}','{1}','{2}','{3}','{4}','{5}')", add.NOMBRE, add.APELLIDO, add.TELEFONO, add.CORREO, add.USUARIO, add.PSWD ), Conexion.getDB());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                return retorno;
            }
        }

        public static List<Usuarios> LlenarDgvUsuarios()
        {
            List<Usuarios> usu = new List<Usuarios>();
            OdbcCommand comando = new OdbcCommand(String.Format("Select * from usuarios"), Conexion.getDB());
            OdbcDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Usuarios us = new Usuarios();
                us.ID = Convert.ToInt32(reader.GetString(0));
                us.NOMBRE = reader.GetString(1);
                us.APELLIDO = reader.GetString(2);
                us.TELEFONO = Convert.ToInt32(reader.GetString(3));
                us.CORREO = reader.GetString(4);
                us.USUARIO = reader.GetString(5);
                usu.Add(us);
            }
            return usu;
        }
    }
}
