using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace FoodTruck.Models
{
    //Abrir conexão com o banco
    public abstract class ModelBase : IDisposable
    {
        protected SqlConnection connection = null;

        public ModelBase()
        {

        }
    }
}