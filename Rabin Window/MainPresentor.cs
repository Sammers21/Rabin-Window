using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rabin_Window.BL;
using StartMenu;
using OpenkeyWindow;

namespace Rabin_Window
{
    class MainPresentor
    {
        private readonly IMainForm _imainForm;
        private readonly IFileManager _manager;
        private readonly IMessageService _messageService;
        private readonly IMenuForm _imenuForm;
        private readonly IOpenKeyForm _iopenkeyForm;

        private string _currentFilePath;

        public MainPresentor(IMainForm imainForm, IFileManager _manager, IMessageService _messageService, IMenuForm imenuForm, IOpenKeyForm iopenkey)
        {
            this._imainForm = imainForm;
            this._manager = _manager;
            this._messageService = _messageService;
            this._imenuForm = imenuForm;
            this._iopenkeyForm = iopenkey;

            _imainForm.SetSymbolCount(0);
            _imainForm.SetByteCount(0);

            _imainForm.FileSaveClick += ImainForm_FileSaveClick;
            _imainForm.FileOpenClick += ImainForm_FileOpenClick;
            _imainForm.GoToMenuClick += ImainForm_GoToMenuClick;
            _imainForm.ContentChanged += ImainForm_ContentChanged;
            _imainForm.FileSaveAsClick += _imainForm_FileSaveAsClick;

            _imenuForm.GoToMainForm += _imenuForm_GoToMainForm;
            _imenuForm.GoToOpenKeyForm += _imenuForm_GoToOpenKeyForm;
            _imenuForm.GoToGenerateKeysWindow += _imenuForm_GoToGenerateKeysWindow;

            _iopenkeyForm.GoToMenuClick += _iopenkeyForm_GoToMenuClick;
            _iopenkeyForm.FileSaveAsClick += _iopenkeyForm_FileSaveAsClick;

        }

        private void _imenuForm_GoToGenerateKeysWindow(object sender, EventArgs e)
        {

        }

        private void _iopenkeyForm_FileSaveAsClick(object sender, EventArgs e)
        {
            string content = _iopenkeyForm.Content;

            _currentFilePath = _iopenkeyForm.path;


            _manager.SaveContent(content, _currentFilePath, _iopenkeyForm.OpenKey);

            _messageService.ShowMessage("Файл успешно сохранён");
        }

        private void _iopenkeyForm_GoToMenuClick(object sender, EventArgs e)
        {
            _imenuForm.ShowForm();
            _iopenkeyForm.SkipForm();
        }

        private void _imenuForm_GoToOpenKeyForm(object sender, EventArgs e)
        {
            _imenuForm.SkipForm();
            _iopenkeyForm.ShowForm();
        }

        private void _imenuForm_GoToMainForm(object sender, EventArgs e)
        {
            _imenuForm.SkipForm();
            _imainForm.ShowForm();
        }

        private void _imainForm_FileSaveAsClick(object sender, EventArgs e)
        {
            string content = _imainForm.Content;

            _currentFilePath = _imainForm.FilePath;


            _manager.SaveContent(content, _currentFilePath, _imainForm.SecretKeyOne * _imainForm.SecretKeyTwo);

            _messageService.ShowMessage("Файл успешно сохранён");
        }

        private void ImainForm_ContentChanged(object sender, EventArgs e)
        {
            _imainForm.SetSymbolCount(_imainForm.Content.Length);
            _imainForm.SetByteCount(Encoding.UTF8.GetBytes(_imainForm.Content).Length);
        }

        private void ImainForm_GoToMenuClick(object sender, EventArgs e)
        {

            _imenuForm.ShowForm();
            _imainForm.SkipForm();

        }

        private void ImainForm_FileOpenClick(object sender, EventArgs e)
        {
            try
            {


                _imainForm.FormGoToWorkMode();
                string filepath = _imainForm.FilePath;
                bool isExist = _manager.isExist(filepath);

                if (!isExist)
                {
                    _messageService.ShowExclamation("Такого файлай не сушествует");
                    return;
                }

                _currentFilePath = filepath;

                

                string Content = _manager.GetContent(_currentFilePath, _imainForm.SecretKeyOne, _imainForm.SecretKeyTwo);

                int count = _manager.GetSymbloCount(Content);

                _imainForm.Content = Content;
                _imainForm.SetSymbolCount(count);

            }
            catch (Exception ex)
            {

                _messageService.ShowError(ex.Message);
            }
            finally
            {
                _imainForm.FormGoToReadyMode();

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
