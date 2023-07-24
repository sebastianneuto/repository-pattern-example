using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Services;
using Infrastructure;

namespace VisualBook
{
    public class VisualBookController : MonoBehaviour
    {
        [SerializeField] private BookRepository _repositorySO;
        [SerializeField] private BookService _service;
        [SerializeField] private TMP_InputField _idInputField;
        [SerializeField] private TMP_InputField _nameInputField;
        [SerializeField] private TMP_InputField _descriptionInputField;
        [SerializeField] private Button _addBookButton;
        [SerializeField] private Button _removeBookButton;
        [SerializeField] private Button _updateBookButton;
        [SerializeField] private Button _getBookButton;
        private void Start ()
        {
            _service = new BookService(_repositorySO);
            _addBookButton.onClick.AddListener(
                () =>
                {
                    _service.AddBook(_idInputField.text, _nameInputField.text, _descriptionInputField.text);
                }
            );

            _removeBookButton.onClick.AddListener(
                () =>
                {
                    _service.RemoveBook(_idInputField.text);
                }
            );

            _updateBookButton.onClick.AddListener(
                () =>
                {
                    _service.UpdateBook(_idInputField.text, _nameInputField.text, _descriptionInputField.text);
                }
            );

            _getBookButton.onClick.AddListener(
                () =>
                {
                    Debug.Log(_service.GetBook(_idInputField.text));
                }
            );
        }

        private void OnDestroy ()
        {
            _addBookButton.onClick.RemoveAllListeners();
            _removeBookButton.onClick.RemoveAllListeners();
            _updateBookButton.onClick.RemoveAllListeners();
            _getBookButton.onClick.RemoveAllListeners();
        }
    }
}