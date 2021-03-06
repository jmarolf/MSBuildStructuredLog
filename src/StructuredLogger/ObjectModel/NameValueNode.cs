﻿namespace Microsoft.Build.Logging.StructuredLogger
{
    public class NameValueNode : ParentedNode, IHasTitle
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string NameAndEquals => Name + " = ";
        public string ShortenedValue => Utilities.ShortenValue(Value);
        public bool IsValueShortened => Value != ShortenedValue;

        public override string ToString() => Name + " = " + Value;
        public bool IsVisible { get { return true; } set { } }
        public bool IsExpanded { get { return true; } set { } }

        string IHasTitle.Title => Name;
    }
}
