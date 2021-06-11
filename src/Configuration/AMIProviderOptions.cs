﻿using System;

namespace Sufficit.AsteriskManager.Configuration
{
    /// <summary>
    /// Parametros de configuração para Asterisk Manager Interface
    /// </summary>
    public class AMIProviderOptions
    {
        /// <summary>
        /// Indica se o provedor de serviços está ativo e deve ser utilizado
        /// </summary>
        public bool Enabled { get; set; } = true;

        public string Title { get; set; }

        public string Address { get; set; }

        public int Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Manter conexão ativa e reconectar sempre que cair (usado para ouvir eventos) <br />
        /// Ou usá-la somente para enviar comandos
        /// </summary>
        public bool KeepAlive { get; set; } = false;
    }
}
