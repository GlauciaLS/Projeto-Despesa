using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PDesp
{
    class Despesa
    {
        private int iddespesa;
        private int idtipodespesa;
        private int idmembro;
        private DateTime datadespesa;
        private float valordespesa;
        private string obsdespesa;

        public int Iddespesa
        {
            get { return iddespesa; }
            set { iddespesa = value; }
        }

        public int Idtipodespesa
        {
            get { return idtipodespesa; }
            set { idtipodespesa = value; }
        }

        public int Idmembro
        {
            get { return idmembro; }
            set { idmembro = value; }
        }

        public DateTime Datadepesa
        {
            get { return datadespesa; }
            set { datadespesa = value; }
        }
        
        public float Valordespesa
        {
            get { return valordespesa; }
            set { valordespesa = value; }
        }

        public string Obsdespesa
        {
            get { return obsdespesa; }
            set { obsdespesa = value; }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daDespesa;
            DataTable dtDespesa = new DataTable();

            try
            {
                daDespesa = new SqlDataAdapter("SELECT * FROM DESPESA", frmPrincipal.conexao);
                daDespesa.Fill(dtDespesa);
                daDespesa.FillSchema(dtDespesa, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dtDespesa;
        }

        public int Salvar()
        {
            int retorno = 0;
            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO DESPESA VALUES (@id_tipodespesa, @id_membro, @data_despesa, @valor_despesa, @obs_despesa)", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_tipodespesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Float));
                mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));

                mycommand.Parameters["@id_tipodespesa"].Value = idtipodespesa;
                mycommand.Parameters["@id_membro"].Value = idmembro;
                mycommand.Parameters["@data_despesa"].Value = datadespesa;
                mycommand.Parameters["@valor_despesa"].Value = valordespesa;
                mycommand.Parameters["@obs_despesa"].Value = obsdespesa;
                

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
                mycommand = new SqlCommand("UPDATE MEMBRO SET tipo_despesa = @tipo_despesa, id_membro = @id_membro, data_despesa = @data_despesa, valor_despesa = @valor_despesa, obs_despesa = @obs_despesa where id_despesa = @id_despesa", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@tipo_despesa", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@id_membro", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@data_despesa", SqlDbType.DateTime));
                mycommand.Parameters.Add(new SqlParameter("@valor_despesa", SqlDbType.Float));
                mycommand.Parameters.Add(new SqlParameter("@obs_despesa", SqlDbType.VarChar));

                mycommand.Parameters["@id_despesa"].Value = iddespesa;
                mycommand.Parameters["@tipo_despesa"].Value = idtipodespesa;
                mycommand.Parameters["@id_membro"].Value = idmembro;
                mycommand.Parameters["@data_despesa"].Value = datadespesa;
                mycommand.Parameters["@valor_despesa"].Value = valordespesa;
                mycommand.Parameters["@obs_despesa"].Value = obsdespesa;

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

                mycommand = new SqlCommand("DELETE FROM DESPESA WHERE id_despesa = @id_despesa", frmPrincipal.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_despesa", SqlDbType.Int));

                mycommand.Parameters["@id_despesa"].Value = iddespesa;

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