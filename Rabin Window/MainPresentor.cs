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

        private string _currentFilePath;

        public MainPresentor(IMainForm imainForm, IFileManager _manager, IMessageService _messageService)
        {
            this._imainForm = imainForm;
            this._manager = _manager;
            this._messageService = _messageService;

            _imainForm.SetSymbolCount(0);
            _imainForm.FileSaveClick += ImainForm_FileSaveClick;
            _imainForm.FileOpenClick += ImainForm_FileOpenClick;
            _imainForm.GoToMenuClick += ImainForm_GoToMenuClick;
            _imainForm.ContentChanged += ImainForm_ContentChanged;
        }

        private void ImainForm_ContentChanged(object sender, EventArgs e)
        {
            _imainForm.SetSymbolCount(_imainForm.Content.Length);
        }

        private void ImainForm_GoToMenuClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ImainForm_FileOpenClick(object sender, EventArgs e)
        {
            try
            {
                string filepath = _imainForm.FilePath;
                bool isExist = _manager.isExist(filepath);

                if (!isExist)
                {
                    _messageService.ShowExclamation("Такого файлай не сушествует");
                    return;
                }

                _currentFilePath = filepath;

                //ToDo проверка ключей

                string Content = _manager.GetContent(_currentFilePath, _imainForm.SecretKeyOne, _imainForm.SecretKeyTwo);

                int count = _manager.GetSymbloCount(Content);

                _imainForm.Content = Content;
                _imainForm.SetSymbolCount(count);

            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void ImainForm_FileSaveClick(object sender, EventArgs e)
        {
            string content = _imainForm.Content;

            _manager.SaveContent(content, _currentFilePath, _imainForm.SecretKeyOne * _imainForm.SecretKeyTwo);

            _messageService.ShowMessage("Файл успешно сохранён");
        }
    }
}
