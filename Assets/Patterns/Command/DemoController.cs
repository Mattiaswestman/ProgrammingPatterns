using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Personal.Patterns.Command
{
    public class DemoController : MonoBehaviour
    {
        [SerializeField]
        private Receiver _receiver;

        private Queue<ICommand> _commandQueue;

        private void Awake()
        {
            _commandQueue = new Queue<ICommand>();
        }

        private void Update()
        {
            HandleInput();
        }

        private void HandleInput()
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                _commandQueue.Enqueue(new CommandA(_receiver, "Pressed up key."));
            }
            if(Input.GetKeyDown(KeyCode.S))
            {
                _commandQueue.Enqueue(new CommandA(_receiver, "Pressed down key."));
            }
            if(Input.GetKeyDown(KeyCode.A))
            {
                _commandQueue.Enqueue(new CommandA(_receiver, "Pressed left key."));
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                _commandQueue.Enqueue(new CommandA(_receiver, "Pressed right key."));
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _commandQueue.Enqueue(new CommandB(_receiver));
            }

            if(Input.GetKeyDown(KeyCode.Return) && (_commandQueue.Count > 0))
            {
                ExecuteCommand(_commandQueue.Dequeue());
            }
        }

        private void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}