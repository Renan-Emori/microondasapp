using Microondas.Models;
using Microondas.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microondas.Controllers
{
    public class ConfigurarController : Controller
    {
      

        public IActionResult AquecerPredef(int id)
        {
            PreDefinidoModel preDefinido = _preDefinidoRepository.ListarPorId(id);
            return View(preDefinido);
        }


        private readonly IPreDefinidoRepository _preDefinidoRepository;
        public ConfigurarController(IPreDefinidoRepository preDefinidoRepository)
        {
            _preDefinidoRepository = preDefinidoRepository;
        }

        // [HttpGet]
        // [Authorize]
        public IActionResult Configurar() 
        {
            List<PreDefinidoModel> preDefinidos = _preDefinidoRepository.BuscarTodos();
            return View(preDefinidos);
        }


        // [HttpGet]
        // [Authorize]
        public IActionResult Inicio()
        {
            return View();
        }

        // [HttpGet]
        // [Authorize]
        public IActionResult Criar()
        {
            return View();
        }

        // [HttpGet]
        // [Authorize]
        public IActionResult Editar(int id)
        {
            PreDefinidoModel preDefinido = _preDefinidoRepository.ListarPorId(id);
            return View(preDefinido);
        }

        // [HttpGet]
        // [Authorize]
        public IActionResult ApagarConfirmacao(int id)
        {
            PreDefinidoModel preDefinido = _preDefinidoRepository.ListarPorId(id);
            return View(preDefinido);
        }

        // [HttpGet]
        // [Authorize]
        public IActionResult Apagar(int id)
        {
            try
            {
                if (id > 5)
                {
                    bool apagado = _preDefinidoRepository.Apagar(id);
                    if (apagado)
                    {
                        TempData["MensagemSucesso"] = "Cadastro apagado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Não foi possível apagar o dado";
                    }
                    return RedirectToAction("Configurar");
                }
                else
                {
                    TempData["MensagemErro"] = "Não é possível apagar um cadastro pré-definido";
                }
                return RedirectToAction("Configurar");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível apagar o cadastro, detalhe do erro: {erro.Message}";
                return RedirectToAction("Configurar");
            }
        }


        [HttpPost]
        public IActionResult Criar(PreDefinidoModel preDefinido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _preDefinidoRepository.Adicionar(preDefinido);
                    TempData["MensagemSucesso"] = "Cadastro feito com sucesso";
                    return RedirectToAction("Configurar");
                }

                return View(preDefinido);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível fazer o cadastro, detalhe do erro: {erro.Message}";
                return RedirectToAction("Configurar");
            }
        }



        [HttpPost]
        public IActionResult Editar(PreDefinidoModel preDefinido)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _preDefinidoRepository.Atualizar(preDefinido);
                    TempData["MensagemSucesso"] = "Cadastro atualizado com sucesso";
                    return RedirectToAction("Configurar");
                }
                return View("Editar", preDefinido);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não foi possível atualizar o cadastro, detalhe do erro: {erro.Message}";
                return RedirectToAction("Configurar");
            }
        }


    }
}
