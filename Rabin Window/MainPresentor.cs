using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rabin_Window.BL;

namespace Rabin_Window
{
    class MainPresentor
    {
        private readonly IMainForm _imainForm;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;

        public MainPresentor(IMainForm imainForm, IFileManager _manager, IMessageService _messageService)
        {
            this._imainForm = imainForm;
            this._manager = _manager;
            this._messageService = _messageService;
        }
    }
}
