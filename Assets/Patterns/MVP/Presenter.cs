using UnityEngine;
using TMPro;

namespace Personal.Patterns.MVP
{
    public class Presenter : MonoBehaviour
    {
        [Header("Model"), SerializeField]
        private Model _model;

        [Header("View"), SerializeField]
        private TextMeshProUGUI _valueText;

        private void Start()
        {
            if(_model != null)
            {
                _model.OnValueChanged += OnValueChanged;
            }
        }

        private void OnDestroy()
        {
            if(_model != null)
            {
                _model.OnValueChanged -= OnValueChanged;
            }
        }

        public void IncrementValue()
        {
            _model.IncrementValue();
        }

        private void UpdateView()
        {
            if(_model == null)
            {
                return;
            }

            if(_valueText != null)
            {
                _valueText.SetText(_model.Value.ToString());
            }
        }

        private void OnValueChanged()
        {
            UpdateView();
        }
    }
}