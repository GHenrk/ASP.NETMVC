using LivrariaControleEmprestimo.DATA.Interfaces;
using LivrariaControleEmprestimo.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.DATA.Repositories

{
    public class RepositoryBase<T> : IRepositoryModel<T>, IDisposable where T : class
    {

        protected ControleEmprestimoLivroContext _Contexto;


        public bool _SaveChanges = true;


        public RepositoryBase(bool saveChanges = true)
        {
            _SaveChanges = saveChanges;
            _Contexto = new ControleEmprestimoLivroContext();

        }

        public T Alterar(T obj)
        {

            _Contexto.Entry(obj).State = EntityState.Modified;

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

            return obj;
        }

        public void Dispose()
        {
            _Contexto.Dispose();
        }

        public void Excluir(T obj)
        {
            _Contexto.Set<T>().Remove(obj);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }

        }

        public void Excluir(params object[] variavel)
        {
            var obj = SelecionarPk(variavel);
            Excluir(obj);

        }

        public T Incluir(T obj)
        {
            _Contexto.Set<T>().Add(obj);

            if (_SaveChanges)
            {
                _Contexto.SaveChanges();
            }
            return obj;
        }

        public void SaveChanges()
        {
            _Contexto.SaveChanges();
        }

        public T SelecionarPk(params object[] variavel)
        {
            return _Contexto.Set<T>().Find(variavel);
        
        }

        public List<T> SelecionarTodos()
        {
            return _Contexto.Set<T>().ToList();
            
        }
    }
}
