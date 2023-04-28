//模板方法

using TemplateMethod;

Template tem = new CharChild("char");

Template tem2 = new StringChild("string");

tem.Display();
tem2.Display();