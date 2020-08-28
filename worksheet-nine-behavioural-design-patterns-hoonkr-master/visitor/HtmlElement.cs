using System;
using System.Collections.Generic;

namespace visitor
{
    public class HtmlElement : HtmlTag,IElement
    {
        private List<HtmlTag> childrenTag;
        public HtmlElement(string tagName)
        {
            TagName = tagName;
            TagBody = "";
            StartTag = "";
            EndTag = "";
        }

        public string TagName { get; set; }
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public string TagBody { get; set; }
        public void AddChildTag(HtmlTag htmlTag)
        {
            childrenTag.Add(htmlTag);
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            childrenTag.Remove(htmlTag);
        }

        public List<HtmlTag> GetChildren()
        {
            return childrenTag;
        }


        public void GenerateHtml()
        {
            Console.WriteLine(StartTag+""+TagBody+""+EndTag);
        }
        
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}