using PCLExt.FileStorage.Folders;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDMTPFINAL.Model
{
    public class Contexto
    {
        public SQLiteConnection conexao;

        public Contexto()
        {
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile("appcadastrofacil", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);
            conexao = new SQLiteConnection(arquivo.Path);
            conexao.CreateTable<Mercadorias>();
        }

        public void Insert<T>(T model)
        {
            conexao.Insert(model);
        }

        public void Update<T>(T model)
        {
            conexao.Update(model);
        }

        public void Delete<T>(T model)
        {
            conexao.Delete(model);
        }
    }
}
