﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tela_de_Login.DAL;

namespace Tela_de_Login.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar (String login , String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
           tem =  loginDao.verificarLogin(login, senha);
            if (! loginDao.mensagem.Equals (""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        internal void cadastrar(object text)
        {
            throw new NotImplementedException();
        }

        public string cadastrar (String email, String senha,String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this. mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }        
    }
}
