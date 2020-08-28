using System;
using System.Collections.Generic;

namespace Composite
{
    public class HtmlParentElement: HtmlTag
    {
        private List<HtmlTag> childrenTag;
        public string TagName { get; }
        private string _StartTag;
        private string _EndTag;
        private string _TagBody;


        public HtmlParentElement(string body)
        {
            TagName = body;
            _StartTag = "";
            _EndTag = "";
            childrenTag = new List<HtmlTag>();
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
        public void AddChildTag(HtmlTag htmlTag)
        {
            childrenTag.Add(htmlTag);
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            childrenTag.Remove(htmlTag);
        }

        public  void GenerateHtml()
        {
            Console.WriteLine(_StartTag);
            foreach (HtmlTag tag in childrenTag)
            {
                tag.GenerateHtml();
            }

            Console.WriteLine(_EndTag);
        }
    }
}