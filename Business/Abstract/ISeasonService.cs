using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISeasonService
    {
        IDataResult<List<Season>> GetSeasons();
        IResult Add(Season season);
        IResult Delete(Season season);
        IResult Update(Season season);
        IDataResult<Season> GetSeasonById(int id);
    }
}
