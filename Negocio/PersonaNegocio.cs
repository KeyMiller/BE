using AutoMapper;
using DBModel.DBBodega;
using DocumentFormat.OpenXml.Office2016.Excel;
using DocumentFormat.OpenXml.Vml.Office;
using INegocio;
using IRepositorio;
using Models.RequestResponse;
using Repositorio;
using UtilInterface;

namespace Negocio
{
    public class PersonaNegocio : IPersonaNegocio
    {
        #region declaracion de variables generales
        public readonly IPersonaRepositorio _IPersonaRepositorio = null;
        public readonly IMapper _mapper;
        #endregion
        #region de constructor
        public PersonaNegocio(IMapper mapper)
        {
            _mapper = mapper;
            _IPersonaRepositorio = new PersonaRepositorio();
        }

        public PersonaResponse Create(PersonaRequest entity)
        {
            Persona cat = _mapper.Map<Persona>(entity);
            cat = _IPersonaRepositorio.Create(cat);
            PersonaResponse res = _mapper.Map<PersonaResponse>(cat);
            return res;
        }

        public List<PersonaResponse> CreateMultiple(List<PersonaRequest> request)
        {
            List<Persona> cat = _mapper.Map<List<Persona>>(request);
            cat = _IPersonaRepositorio.InsertMultiple(cat);
            List<PersonaResponse> res = _mapper.Map<List<PersonaResponse>>(cat);
            return res;
        }

        public int Delete(object id)
        {
            return _IPersonaRepositorio.Delete(id);
        }

        public int DeleteMultipleItems(List<PersonaRequest> request)
        {
            List<Persona> cat = _mapper.Map<List<Persona>>(request);
            int cantidad = _IPersonaRepositorio.DeleteMultipleItems(cat);
            return cantidad;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<PersonaResponse> GetAll()
        {
            List<Persona> lst = _IPersonaRepositorio.GetAll();
            List<PersonaResponse> res = _mapper.Map<List<PersonaResponse>>(lst);
            return res;
        }

        public List<PersonaResponse> GetAutoComplete(string query)
        {
            throw new NotImplementedException();
        }

        public PersonaResponse GetById(int id)
        {
            Persona cat = _IPersonaRepositorio.GetById(id);
            PersonaResponse res = _mapper.Map<PersonaResponse>(cat);
            return res;
        }

        public PersonaResponse Update(PersonaRequest entity)
        {
            Persona cat = _mapper.Map<Persona>(entity);
            cat = _IPersonaRepositorio.Update(cat);
            PersonaResponse res = _mapper.Map<PersonaResponse>(cat);
            return res;
        }

        public List<PersonaResponse> UpdateMultiple(List<PersonaRequest> request)
        {
            List<Persona> cat = _mapper.Map<List<Persona>>(request);
            cat = _IPersonaRepositorio.UpdateMultiple(cat);
            List<PersonaResponse> res = _mapper.Map<List<PersonaResponse>>(cat);
            return res;
        }
    }
}
#endregion