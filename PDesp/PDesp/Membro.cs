﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Membro
    {
        private int idmembro;
        private string nomemembro;
        private string papelmembro;

        public int Idmembro {
            get { return idmembro; }
            set { idmembro = value; }            
        }

        public string Nomemembro {
            get { return nomemembro; }
            set { nomemembro = value; }
        }

        public string Papelmembro {
            get { return papelmembro; }
            set { papelmembro = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daMembro;
            DataTable dtMembro = new DataTable();

            try
            {
                daMembro = new SqlDataAdapter("SELECT * FROM MEMBRO", frmPrincipal.conexao);
                daMembro.Fill(dtMembro);
                daMembro.FillSchema(dtMembro, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtMembro;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO MEMBRO VALUES (@nome_membro, @papel_membro)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                mycommand.Parameters["@nome_membro"].Value = nomemembro;
                mycommand.Parameters["@papel_membro"].Value = papelmembro;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;
                mycommand = new SqlCommand("UPDATE MEMBRO SET nome_membro = @nome_membro, papel_membro = @papel_membro where id_membro = @id_membro", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_membro", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@papel_membro", SqlDbType.VarChar));

                mycommand.Parameters["@id_membro"].Value = idmembro;
                mycommand.Parameters["@nome_membro"].Value = nomemembro;
                mycommand.Parameters["@papel_membro"].Value = papelmembro;

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }

            }

            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public int Excluir()
        {
            int nReg;
            int retorno = 0;

            try
            {
                SqlCommand mycommand;                

                mycommand = new SqlCommand("DELETE FROM MEMBRO WHERE id_membro = @id_membro", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));                

                mycommand.Parameters["@id_membro"].Value = idmembro;                

                nReg = mycommand.ExecuteNonQuery();

                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;

        }


    }
}
