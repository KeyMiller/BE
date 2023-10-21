using AutoMapper;
using DBModel.DBBodega;
using DocumentFormat.OpenXml.Office2016.Excel;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CargoColaborativoNegocio : ICargoColaborativoNegocio
    {
        #region declaracion de variables generales
        public readonly ICargoColaborativoRepositorio _ICargoColaborativoRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public CargoColaborativoNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _ICargoColaborativoRepositorio = new CargoColaborativoRepositorio();
        }

        public CargoColaborativoResponse Create(CargoColaborativoRequest entity)
        {
            Cargocolaborativo cat = _mapper.Map<Cargocolaborativo>(entity);
            cat = _ICargoColaborativoRepositorio.Create(cat);
            CargoColaborativoResponse res = _mapper.Map<CargoColaborativoResponse>(cat);
            return res;
        }

        public List<CargoColaborativoResponse> CreateMultiple(List<CargoColaborativoRequest> request)
        {
            List<Cargocolaborativo> cat = _mapper.Map<List<Cargocolaborativo>>(request);
            cat = _ICargoColaborativoRepositorio.InsertMultiple(cat);
            List<CargoColaborativoResponse> res = _mapper.Map<List<CargoColaborativoResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _ICargoColaborativoRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<CargoColaborativoRequest> request)
        {
            List<Cargocolaborativo> cat = _mapper.Map<List<Cargocolaborativo>>(request);
            int cantidad = _ICargoColaborativoRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<CargoColaborativoResponse> GetAll()
        {
            List<Cargocolaborativo> lst = _ICargoColaborativoRepositorio.GetAll();
            List<CargoColaborativoResponse> res = _mapper.Map<List<CargoColaborativoResponse>>(lst);
            return res;
        }

        public List<CargoColaborativoResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public CargoColaborativoResponse GetById(int id)
        {
            Cargocolaborativo cat = _ICargoColaborativoRepositorio.GetById(id);
            CargoColaborativoResponse res = _mapper.Map<CargoColaborativoResponse>(cat);
            return res;
        }

        public CargoColaborativoResponse Update(CargoColaborativoRequest entity)
        {
            Cargocolaborativo cat = _mapper.Map<Cargocolaborativo>(entity);
            cat = _ICargoColaborativoRepositorio.Update(cat);
            CargoColaborativoResponse res = _mapper.Map<CargoColaborativoResponse>(cat);
            return res;
        }

        public List<CargoColaborativoResponse> UpdateMultiple(List<CargoColaborativoRequest> request)
        {
            List<Cargocolaborativo> cat = _mapper.Map<List<Cargocolaborativo>>(request);
            cat = _ICargoColaborativoRepositorio.UpdateMultiple(cat);
            List<CargoColaborativoResponse> res = _mapper.Map<List<CargoColaborativoResponse>>(cat);
            return res;
        }
    }
}
#endregion