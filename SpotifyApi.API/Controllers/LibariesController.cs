﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpotifyApi.Business.Abstract;
using SpotifyApi.Entity.DTO.LibraryDtos;

namespace SpotifyApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibariesController : ControllerBase
    {
        private readonly ILibaryService _libraryService;

        public LibariesController(ILibaryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("create")]
        public IActionResult Add(LibaryCreateDto dto)
        {
            var result = _libraryService.Add(dto);
            return Ok(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll(string token)
        {
            var result = _libraryService.GetAll(token);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var result = _libraryService.Delete(id);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(LibaryUpdateDto dto)
        {
            var result = _libraryService.Update(dto);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id, string token)
        {
            var result = _libraryService.GetById(id, token);
            return Ok(result);
        }

     
    }
}
