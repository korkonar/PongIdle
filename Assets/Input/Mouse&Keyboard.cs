// GENERATED AUTOMATICALLY FROM 'Assets/Input/Mouse&Keyboard.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseKeyboard : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseKeyboard()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mouse&Keyboard"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""38963743-079f-447d-97ff-907d2d424a49"",
            ""actions"": [
                {
                    ""name"": ""MovePalet"",
                    ""type"": ""Value"",
                    ""id"": ""5e2f08bf-2d57-4187-bcfa-a6469406833c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""92156210-443c-4bae-a70b-338086caf50a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePalet"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0e7c00e7-b5ae-4225-a284-023f562ff005"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovePalet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7f516c05-1b92-4f0a-bfb3-4176adf4b3f2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovePalet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""90edc557-3d29-4306-b25f-cc235c56736f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePalet"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b69f0f70-178a-4c08-8f8f-1364634559c4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovePalet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2b3bccb0-ba37-4f01-9b0f-11e496084601"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse&Keyboard"",
                    ""action"": ""MovePalet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse&Keyboard"",
            ""bindingGroup"": ""Mouse&Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MovePalet = m_Player.FindAction("MovePalet", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MovePalet;
    public struct PlayerActions
    {
        private @MouseKeyboard m_Wrapper;
        public PlayerActions(@MouseKeyboard wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePalet => m_Wrapper.m_Player_MovePalet;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MovePalet.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePalet;
                @MovePalet.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePalet;
                @MovePalet.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovePalet;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePalet.started += instance.OnMovePalet;
                @MovePalet.performed += instance.OnMovePalet;
                @MovePalet.canceled += instance.OnMovePalet;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse&Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovePalet(InputAction.CallbackContext context);
    }
}
