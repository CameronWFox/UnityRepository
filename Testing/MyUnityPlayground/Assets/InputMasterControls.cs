// GENERATED AUTOMATICALLY FROM 'Assets/InputMasterControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMasterControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMasterControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMasterControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""a3c81a1a-91ed-405b-a6ee-74faad5c0b67"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""8067fd09-c82c-4687-b55f-91de8ffaf794"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""c895ba70-b59f-4d1f-ae53-af2e866c4d4f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d63248c0-a8a4-4586-b733-964f5d12e92f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8cd2daed-65ea-42cc-8aa0-fa5fc9861be5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dff274f7-e4bb-49c2-801c-48526a2f49b9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""effd37c6-3570-4640-a181-5c26af4a5406"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""IJKL"",
                    ""id"": ""4fdda9a8-9967-4d2d-ba11-972a9be1de92"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3cc766e9-f20e-4de1-bc06-8e19aca28b13"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4461aba-aaf8-48f9-a560-41ddbf667512"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6caee131-0f84-4b82-aefb-fb69a03f7976"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""055b489d-3b9b-4eac-8756-cc220416f4f7"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""e0785784-343d-49cd-a291-885d6a424300"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""17f7c151-d3f0-4e9c-8cae-cafcc319c0ee"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0faa6b57-aa02-4897-ba20-9320ff42e332"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c39eb07b-e2a9-4be7-b7c4-4ddfba208b00"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f80b5dee-f58f-4db6-bb9d-2421f9e82aa6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7f02a4f7-6e8a-4a48-a2b4-01d67ffee06b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""AI"",
            ""id"": ""78e575c1-1194-4fa4-aeb1-097e4999283c"",
            ""actions"": [
                {
                    ""name"": ""Patrol"",
                    ""type"": ""Button"",
                    ""id"": ""3b3cf7e7-55ff-433d-a16e-f4d62a60e3a3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Wander"",
                    ""type"": ""Button"",
                    ""id"": ""d88ae46c-c4cb-48d7-b41b-0177bba6d774"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Track"",
                    ""type"": ""Button"",
                    ""id"": ""71e3c7ad-ff4e-4c31-bc0b-bc4936a4fa6a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Chase"",
                    ""type"": ""Button"",
                    ""id"": ""c3fbfd22-a08c-4ad2-88e1-9bcb00f71b3b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e0d8f5d4-e43e-4c95-88a1-1f83e195fc85"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Patrol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e45f478-294c-4337-99d4-3474d74284ee"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wander"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dca1ff69-55d7-4db8-9c0a-643f7ed49221"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Track"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea500e1-7b19-4a8b-8795-544aae3406d8"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Chase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""8851abac-bc33-4b8c-a560-ebbeb49e989f"",
            ""actions"": [
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""f1dce723-31f1-415f-8682-64481486c3f9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e19bd7c4-b6ee-4aa1-9e87-d641a6fa64cc"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        // AI
        m_AI = asset.FindActionMap("AI", throwIfNotFound: true);
        m_AI_Patrol = m_AI.FindAction("Patrol", throwIfNotFound: true);
        m_AI_Wander = m_AI.FindAction("Wander", throwIfNotFound: true);
        m_AI_Track = m_AI.FindAction("Track", throwIfNotFound: true);
        m_AI_Chase = m_AI.FindAction("Chase", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Inventory = m_UI.FindAction("Inventory", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    public struct PlayerActions
    {
        private @InputMasterControls m_Wrapper;
        public PlayerActions(@InputMasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // AI
    private readonly InputActionMap m_AI;
    private IAIActions m_AIActionsCallbackInterface;
    private readonly InputAction m_AI_Patrol;
    private readonly InputAction m_AI_Wander;
    private readonly InputAction m_AI_Track;
    private readonly InputAction m_AI_Chase;
    public struct AIActions
    {
        private @InputMasterControls m_Wrapper;
        public AIActions(@InputMasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Patrol => m_Wrapper.m_AI_Patrol;
        public InputAction @Wander => m_Wrapper.m_AI_Wander;
        public InputAction @Track => m_Wrapper.m_AI_Track;
        public InputAction @Chase => m_Wrapper.m_AI_Chase;
        public InputActionMap Get() { return m_Wrapper.m_AI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AIActions set) { return set.Get(); }
        public void SetCallbacks(IAIActions instance)
        {
            if (m_Wrapper.m_AIActionsCallbackInterface != null)
            {
                @Patrol.started -= m_Wrapper.m_AIActionsCallbackInterface.OnPatrol;
                @Patrol.performed -= m_Wrapper.m_AIActionsCallbackInterface.OnPatrol;
                @Patrol.canceled -= m_Wrapper.m_AIActionsCallbackInterface.OnPatrol;
                @Wander.started -= m_Wrapper.m_AIActionsCallbackInterface.OnWander;
                @Wander.performed -= m_Wrapper.m_AIActionsCallbackInterface.OnWander;
                @Wander.canceled -= m_Wrapper.m_AIActionsCallbackInterface.OnWander;
                @Track.started -= m_Wrapper.m_AIActionsCallbackInterface.OnTrack;
                @Track.performed -= m_Wrapper.m_AIActionsCallbackInterface.OnTrack;
                @Track.canceled -= m_Wrapper.m_AIActionsCallbackInterface.OnTrack;
                @Chase.started -= m_Wrapper.m_AIActionsCallbackInterface.OnChase;
                @Chase.performed -= m_Wrapper.m_AIActionsCallbackInterface.OnChase;
                @Chase.canceled -= m_Wrapper.m_AIActionsCallbackInterface.OnChase;
            }
            m_Wrapper.m_AIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Patrol.started += instance.OnPatrol;
                @Patrol.performed += instance.OnPatrol;
                @Patrol.canceled += instance.OnPatrol;
                @Wander.started += instance.OnWander;
                @Wander.performed += instance.OnWander;
                @Wander.canceled += instance.OnWander;
                @Track.started += instance.OnTrack;
                @Track.performed += instance.OnTrack;
                @Track.canceled += instance.OnTrack;
                @Chase.started += instance.OnChase;
                @Chase.performed += instance.OnChase;
                @Chase.canceled += instance.OnChase;
            }
        }
    }
    public AIActions @AI => new AIActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Inventory;
    public struct UIActions
    {
        private @InputMasterControls m_Wrapper;
        public UIActions(@InputMasterControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Inventory => m_Wrapper.m_UI_Inventory;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Inventory.started -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnInventory;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IAIActions
    {
        void OnPatrol(InputAction.CallbackContext context);
        void OnWander(InputAction.CallbackContext context);
        void OnTrack(InputAction.CallbackContext context);
        void OnChase(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnInventory(InputAction.CallbackContext context);
    }
}
