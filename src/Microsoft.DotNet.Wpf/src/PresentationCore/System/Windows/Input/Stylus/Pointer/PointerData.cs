// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


// using static MS.Win32.Pointer.UnsafeNativeMethods;
using WinPointer = Windows.Win32.UI.Input.Pointer;
using WinPointerInput = Windows.Win32.UI.WindowsAndMessaging;

namespace System.Windows.Input.StylusPointer
{
    /// <summary>
    /// Provides a wrapping class that aggregates Pointer data from a pointer event/message
    /// </summary>
    internal class PointerData
    {
        #region Member Variables

        /// <summary>
        /// Standard pointer information
        /// </summary>
        private WinPointer.POINTER_INFO _info;

        /// <summary>
        /// Pointer information specific to a touch device
        /// </summary>
        private WinPointer.POINTER_TOUCH_INFO _touchInfo;

        /// <summary>
        /// Pointer information specific to a pen device
        /// </summary>
        private WinPointer.POINTER_PEN_INFO _penInfo;

        /// <summary>
        /// The full history available for the current pointer (used for coalesced input)
        /// </summary>
        private WinPointer.POINTER_INFO[] _history;

        #endregion

        #region Properties

        /// <summary>
        /// If true, we have correctly queried pointer data, false otherwise.
        /// </summary>
        internal bool IsValid { get; private set; } = false;

        /// <summary>
        /// Standard pointer information
        /// </summary>
        internal WinPointer.POINTER_INFO Info
        {
            get
            {
                return _info;
            }
        }

        /// <summary>
        /// Pointer information specific to a touch device
        /// </summary>
        internal WinPointer.POINTER_TOUCH_INFO TouchInfo
        {
            get
            {
                return _touchInfo;
            }
        }

        /// <summary>
        /// Pointer information specific to a pen device
        /// </summary>
        internal WinPointer.POINTER_PEN_INFO PenInfo
        {
            get
            {
                return _penInfo;
            }
        }

        /// <summary>
        /// The full history available for the current pointer (used for coalesced input)
        /// </summary>
        internal WinPointer.POINTER_INFO[] History
        {
            get
            {
                return _history;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Queries all needed data from a particular pointer message and stores
        /// it locally.
        /// </summary>
        /// <param name="pointerId">The id of the pointer message</param>
        internal unsafe PointerData(uint pointerId)
        {
            if (IsValid = PInvokeCore.GetPointerInfo(pointerId, out _info))
            {
                _history = new WinPointer.POINTER_INFO[_info.historyCount];

                bool isSuccessful = true;

                fixed (WinPointer.POINTER_INFO* ptrHistory = _history)
                {
                    // Fill the pointer history
                    // If we fail just return a blank history
                    if (!PInvokeCore.GetPointerInfoHistory(pointerId, ref _info.historyCount, ptrHistory))
                    {
                        isSuccessful = false;
                    }
                }

                if(!isSuccessful) _history = Array.Empty<WinPointer.POINTER_INFO>();

                switch (_info.pointerType)
                {
                    case WinPointerInput.POINTER_INPUT_TYPE.PT_TOUCH:
                        {
                            // If we have a touch device, pull the touch specific information down
                            IsValid &= PInvokeCore.GetPointerTouchInfo(pointerId, out _touchInfo);
                        }
                        break;
                    case WinPointerInput.POINTER_INPUT_TYPE.PT_PEN:
                        {
                            // Otherwise we have a pen device, so pull down pen specific information
                            IsValid &= PInvokeCore.GetPointerPenInfo(pointerId, out _penInfo);
                        }
                        break;
                    default:
                        {
                            // Only process touch or pen messages, do not process mouse or touchpad
                            IsValid = false;
                        }
                        break;
                }
            }
        }

        #endregion
    }
}
