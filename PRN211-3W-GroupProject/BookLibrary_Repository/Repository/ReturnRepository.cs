using BookLibrary_Repository.Dao;
using BookLibrary_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary_Repository.Repository
{
    public class ReturnRepository : IReturnRepository
    {
        public void CreateReturn(TblReturn tblReturn) => ReturnDBContext.Instance.CreateReturn(tblReturn);

        public TblReturn? GetReturn(int returnID) => ReturnDBContext.Instance.GetReturn(returnID);

        public List<TblReturn> GetReturns(string memberID) => ReturnDBContext.Instance.GetReturns(memberID);
    }
}
