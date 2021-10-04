// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""a428f5ad-e095-4c3b-a0f5-426769cc5ae6"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a9ec3507-996b-43f7-8957-d16b897aa239"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b8c1dd49-c8ea-466c-a8ab-3eef366190c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""1053c11a-e1cb-445f-a46b-90044f21faad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""90c2b4c3-ab19-47cb-9ab4-22f54c059db8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeftStop"",
                    ""type"": ""Button"",
                    ""id"": ""a5732dc0-63ac-4f60-87a3-2eacdbb4b634"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""MoveRightStop"",
                    ""type"": ""Button"",
                    ""id"": ""fa6812c9-650b-405f-bc44-ce2ab014c4ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""990fd957-ffec-426b-bfd3-aae51e25676c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0aa62e6e-6938-4291-81ee-3dfb1e67fee9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""119c07d4-414f-44bf-98f9-566e6d618e4c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2893ee97-ad15-4aca-a21b-1e11ccce6a27"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b34021a2-cf18-405c-ac2c-209d55572d4f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e426d80d-d699-4766-8791-8ec9d9d3939b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightStop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Jump = m_PlayerActions.FindAction("Jump", throwIfNotFound: true);
        m_PlayerActions_MoveLeft = m_PlayerActions.FindAction("MoveLeft", throwIfNotFound: true);
        m_PlayerActions_MoveRight = m_PlayerActions.FindAction("MoveRight", throwIfNotFound: true);
        m_PlayerActions_Attack = m_PlayerActions.FindAction("Attack", throwIfNotFound: true);
        m_PlayerActions_MoveLeftStop = m_PlayerActions.FindAction("MoveLeftStop", throwIfNotFound: true);
        m_PlayerActions_MoveRightStop = m_PlayerActions.FindAction("MoveRightStop", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Jump;
    private readonly InputAction m_PlayerActions_MoveLeft;
    private readonly InputAction m_PlayerActions_MoveRight;
    private readonly InputAction m_PlayerActions_Attack;
    private readonly InputAction m_PlayerActions_MoveLeftStop;
    private readonly InputAction m_PlayerActions_MoveRightStop;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerActions_Jump;
        public InputAction @MoveLeft => m_Wrapper.m_PlayerActions_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_PlayerActions_MoveRight;
        public InputAction @Attack => m_Wrapper.m_PlayerActions_Attack;
        public InputAction @MoveLeftStop => m_Wrapper.m_PlayerActions_MoveLeftStop;
        public InputAction @MoveRightStop => m_Wrapper.m_PlayerActions_MoveRightStop;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJump;
                @MoveLeft.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRight;
                @Attack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAttack;
                @MoveLeftStop.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftStop;
                @MoveLeftStop.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftStop;
                @MoveLeftStop.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftStop;
                @MoveRightStop.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRightStop;
                @MoveRightStop.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRightStop;
                @MoveRightStop.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveRightStop;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @MoveLeftStop.started += instance.OnMoveLeftStop;
                @MoveLeftStop.performed += instance.OnMoveLeftStop;
                @MoveLeftStop.canceled += instance.OnMoveLeftStop;
                @MoveRightStop.started += instance.OnMoveRightStop;
                @MoveRightStop.performed += instance.OnMoveRightStop;
                @MoveRightStop.canceled += instance.OnMoveRightStop;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerActionsActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMoveLeftStop(InputAction.CallbackContext context);
        void OnMoveRightStop(InputAction.CallbackContext context);
    }
}
