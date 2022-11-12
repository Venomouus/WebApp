using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq.Expressions;
using WebApp.Models;
using WebApp.Repositorio;

namespace WebApp.Controllers
{
    public class OnibusController : Controller
    {
        private readonly IOnibusRepositorio _onibusRepositorio;
        public OnibusController(IOnibusRepositorio onibusRepositorio)
        {
            _onibusRepositorio = onibusRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            OnibusModel onibus = _onibusRepositorio.BuscarPorId(id);
            return View(onibus);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            OnibusModel onibus = _onibusRepositorio.BuscarPorId(id);
            return View(onibus);
        }

        public IActionResult Apagar(int id)
        {
            try
            {

                bool apagado = _onibusRepositorio.Apagar(id);
                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Onibus apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Falha ao Apagar Onibus";
                }
                return RedirectToAction("Index");

            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Falha ao Apagar Onibus erro:{erro}";
                return RedirectToAction("Index");

            }
        }

        [HttpPost]
        public IActionResult Criar(OnibusModel onibus)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    onibus = _onibusRepositorio.Adicionar(onibus);

                    TempData["MensagemSucesso"] = "Onibus Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(onibus);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Cadastrar Onibus: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public IActionResult Editar(OnibusModel onibus)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    onibus = _onibusRepositorio.Atualizar(onibus);

                    TempData["MensagemSucesso"] = "Cliente Alterado com sucesso";
                    return RedirectToAction("Index");

                }
                return View("Editar", onibus);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Erro ao Alterar Cliente: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}

