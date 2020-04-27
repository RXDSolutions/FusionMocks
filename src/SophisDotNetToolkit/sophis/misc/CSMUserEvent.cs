//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;
using System.Collections.Generic;
using sophis.utils;

namespace sophis.misc
{
    public class CSMUserEvent : IDisposable
    {
        private struct ValueHolder
        {
            public readonly eMType type;
            public readonly object value;

            public ValueHolder(eMType type, object value)
            {
                this.type = type;
                this.value = value;
            }
        }

        private Dictionary<int, ValueHolder> _events = new Dictionary<int, ValueHolder>();
            
        public enum eMType
        {
            M_eUserEvent = 9,
            M_eBuffer = 8,
            M_eString = 7,
            M_eDouble = 6,
            M_eFloat = 5,
            M_eLongLong = 4,
            M_eLong = 3,
            M_eShort = 2,
            M_eChar = 1,
            M_eBool = 0
        }
        
        public CSMUserEvent()
        {
        }

        public unsafe eMEventErrorCode Add(int tag, CSMUserEvent value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eUserEvent, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, CMString value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eString, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, double value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eDouble, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, float value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eFloat, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, long value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eLongLong, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, int value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eLong, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, short value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eShort, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Add(int tag, bool value)
        {
            _events.Add(tag, new ValueHolder(eMType.M_eBool, value));

            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe int GetEventClass()
        {
            return 1;
        }

        public unsafe int GetEventID()
        {
            return 1;
        }

        public unsafe int GetElementCount()
        {
            return _events.Count;
        }

        public unsafe eMEventErrorCode Get(int tag, CSMUserEvent value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref double value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref float value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref long value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref int value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref short value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode Get(int tag, ref bool value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, CSMUserEvent value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref double value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref float value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref long value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref int value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref short value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public unsafe eMEventErrorCode GetAt(int index, ref bool value)
        {
            return eMEventErrorCode.M_eecNoError;
        }

        public void Dispose()
        {
        }
    }
}