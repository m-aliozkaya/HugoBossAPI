using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SeasonManager : ISeasonService
    {
        ISeasonDal _seasonDal;

        public SeasonManager(ISeasonDal seasonDal)
        {
            _seasonDal = seasonDal;
        }

        public IResult Add(Season season)
        {
            _seasonDal.Add(season);
            return new SuccessResult();
        }

        public IResult Delete(Season season)
        {
            _seasonDal.Delete(season);
            return new SuccessResult();
        }

        public IDataResult<Season> GetSeasonById(int id)
        {
            return new SuccessDataResult<Season>(_seasonDal.Get(s => s.Id == id));
        }

        public IDataResult<List<Season>> GetSeasons()
        {
            return new SuccessDataResult<List<Season>>(_seasonDal.GetAll());
        }

        public IResult Update(Season season)
        {
            _seasonDal.Update(season);
            return new SuccessResult();
        }
    }
}
