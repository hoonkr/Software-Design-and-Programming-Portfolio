using System;
using System.Collections.Generic;

namespace Composite
{
    public class HtmlElement: HtmlTag
    {
        public string TagName { get; }
        private string _StartTag;
        private string _EndTag;
        private string _TagBody;
        private List<HtmlTag> childrenTag;
        public HtmlElement(string s)
        {
            TagName = s;
            _TagBody = "";
            _StartTag = "";
            _EndTag = "";
        }

        public void AddChildTag(HtmlTag htmlTag)
        {
            childrenTag.Add(htmlTag);
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            childrenTag.Remove(htmlTag);
        }
        public void TagBody(string tagBody)
        {
            _TagBody = tagBody;
        }

        public void StartTag(string tag)
        {
            _StartTag = tag;
        }

        public void EndTag(string tag)
        {
            _EndTag = tag;
        }

        public List<HtmlTag> Children()
        {
            return childrenTag;
        }

        public void GenerateHtml()
        {
            Console.WriteLine(_StartTag+""+_TagBody+""+_EndTag);
        }
    }
}