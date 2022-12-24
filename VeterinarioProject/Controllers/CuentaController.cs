using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VeterinarioEN;
using VeterinarioWS.Interface;
using VeterinarioProject;

namespace VeterinarioProject.Controllers
{
    public class CuentaController : Controller
    {
        // GET: Cuenta
        public ActionResult Index()
        {
            if (Session["oEnUsuario"] != null)
            {
                TempData["vMensaje"] = "E|Para cambiar de usuario, cierre su sesion actual";
                return RedirectToAction("Login");
            }
            Session["oEnUsuario"] = null;
            return View();
        }

        // GET: Cuenta/Details/5
        public ActionResult Login(FormCollection fm)
        {
            UsuarioEN poUsuarioEN = new UsuarioEN();    
            UsuarioEN oEnUSuario = new UsuarioEN();

            try
            {
                string sUsuario = fm["txtUsuario"].ToString();
                string sClave = fm["txtClave"].ToString();
                string sMensajeRespuesta = string.Empty;

                if (sUsuario.Trim() != "" && sClave.Trim() != "")
                {
                    poUsuarioEN.sLogin = sUsuario;
                    poUsuarioEN.sPassWord = sClave;
                    using (IwsVeterinario wsLogin = new IwsVeterinario())
                    {
                        oEnUsuario = wsLogin.WsAutenticarUsuario(sUsuario, sClave);

                        if (oEnUsuario.sCorreo != "" && oEnUsuario.sCorreo != null)
                        {
                            sMensajeRespuesta = "El usuario ingresó con éxito.";
                            oEnUsuario.sRespuesta = sMensajeRespuesta;
                        }
                        else
                        {
                            sMensajeRespuesta = "El usuario Y/O contraseña son incorrectos.";
                            oEnUsuario.sRespuesta = sMensajeRespuesta;
                        }
                    }
                    if (oEnUsuario.sCorreo != "" && oEnUsuario.sCorreo != null)
                    {
                        Session["SessionUsuario"] = oEnUsuario;
                        return RedirectToAction("InicioSession");
                    }
                    else
                    {
                        TempData["vMensaje"] = "E|" + oEnUsuario.sRespuesta;
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    TempData["vMensaje"] = "W|Debe ingresar el Usuario o Clave.";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["vMensaje"] = "E|Ha ocurrido un error inesperado, si el problema continua, intente nuevamente mas tarde";
                return RedirectToAction("Index");
                throw ex;
            }
            return View();
        }

        // GET: Cuenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cuenta/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cuenta/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cuenta/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cuenta/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
