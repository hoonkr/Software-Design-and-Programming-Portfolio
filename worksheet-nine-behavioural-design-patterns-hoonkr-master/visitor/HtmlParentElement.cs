using System;
using System.Collections;
using System.Collections.Generic;

namespace visitor
{
    public class HtmlParentElement : HtmlTag,IElement
    {
        private List<HtmlTag> childrenTag;
        public HtmlParentElement(string tagName)
        {
            TagName = tagName;
            StartTag = "";
            EndTag = "";
            childrenTag = new List<HtmlTag>();

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

        public void Accept(IVisitor visitor) => visitor.Visit(this);

        public void GenerateHtml()
        {
            Console.WriteLine(StartTag);
            foreach (HtmlTag tag in childrenTag)
            {
                tag.GenerateHtml();
            }
            Console.WriteLine(EndTag);
        }
    }
}