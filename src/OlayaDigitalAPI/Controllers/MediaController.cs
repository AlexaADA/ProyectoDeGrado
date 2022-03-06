using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OlayaDigital.Core.DTOs;
using OlayaDigital.Core.Entities;
using OlayaDigital.Core.Intarfaces;
using OlayaDigitalAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlayaDigitalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly IRepository _postRepository;

        public MediaController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetImages()
        {
            IEnumerable<Media> _data = _unitOfWork.MediaRepository.GetAll();

            //Mapeo con AutoMapper
            var _dataMapper = _mapper.Map<IEnumerable<MediaDto>>(_data);

            //Estructurar el response del api
            var _response = new ApiResponse<IEnumerable<MediaDto>>(_dataMapper)
            {
                Msg = "Resultado de la busqueda"
            };

            await Task.CompletedTask;
            return Ok(_response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByMedia(int id)
        {
            var _data = await _unitOfWork.MediaRepository.GetById(id);
            var _dataDto = _mapper.Map<MediaDto>(_data);

            //Estructurar el response del api
            var _response = new ApiResponse<MediaDto>(_dataDto);
            return Ok(_response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MediaDto model)
        {
            var _data = _mapper.Map<Media>(model);
            await _unitOfWork.MediaRepository.Add(_data);
            await _unitOfWork.saveChangesAsync();
            var _dataDto = _mapper.Map<MediaDto>(_data);

            //Estructurar el response del api
            var _response = new ApiResponse<MediaDto>(_dataDto);
            return Ok(_response);
        }

        //Ejemplo para actualizar una entidad https: //localhost:44389/api/post?id=1
        [HttpPut]
        public async Task<IActionResult> Put(int id, MediaDto modelDto)
        {
            var _data = _mapper.Map<Media>(modelDto);
            modelDto.Id = id;
            _unitOfWork.MediaRepository.Update(_data);

            await _unitOfWork.saveChangesAsync();
            //Estructurar el response del api
            return Ok("Registro guardado éxitosamente");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _unitOfWork.MediaRepository.Delete(id);
            await _unitOfWork.saveChangesAsync();
            //Estructurar el response del api
            return Ok("El registo se elimino exitosamente");
        }
    }
}
