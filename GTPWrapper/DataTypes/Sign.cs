﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTPWrapper.DataTypes {
    /// <summary>
    /// Represents a whole number between -1 and 1.
    /// </summary>
    public struct Sign {
        public readonly int Value;

        /// <summary>
        /// Initializes a new instance of the Sign class with given value modulo 3.
        /// </summary>
        /// <param name="value">The value.</param>
        public Sign(int value) {
            this.Value = value % 3;
            this.Value = this.Value == 2 ? -1 : this.Value == -2 ? 1 : this.Value;
        }

        #region Operators

        public override int GetHashCode() {
            return ((int)this).GetHashCode();
        }

        public override bool Equals(object obj) {
            return obj is Sign && this == (Sign)obj;
        }

        public static Sign operator +(Sign s1, Sign s2) {
            return new Sign(s1.Value + s2.Value);
        }

        public static Sign operator -(Sign s) {
            return new Sign(-s.Value);
        }

        public static Sign operator -(Sign s1, Sign s2) {
            return -s2 + s1;
        }

        public static bool operator ==(Sign s1, Sign s2) {
            return (int)s1 == (int)s2;
        }

        public static bool operator !=(Sign s1, Sign s2) {
            return (int)s1 != (int)s2;
        }

        public static implicit operator Sign(int value) {
            return new Sign(value);
        }

        public static explicit operator int(Sign sign) {
            return sign.Value;
        }

        public static implicit operator Sign(Color color) {
            return new Sign((int)color);
        }

        public static explicit operator Color(Sign sign) {
            return (Color)sign.Value;
        }

        #endregion
    }
}
