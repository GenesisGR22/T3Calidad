#pragma checksum "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "715a8073a9dc7ae114744a97978d9af1f2103cad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota_Create), @"mvc.1.0.view", @"/Views/Nota/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\_ViewImports.cshtml"
using T3Calidad_N00024035;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\_ViewImports.cshtml"
using T3Calidad_N00024035.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715a8073a9dc7ae114744a97978d9af1f2103cad", @"/Views/Nota/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"111f5993ad5acfb781da3ef75cd1be3fd885e080", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("createNota"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("guardar(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
   Layout = null;
    var nota = (Nota)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "715a8073a9dc7ae114744a97978d9af1f2103cad5264", async() => {
                WriteLiteral("\n\n    <div class=\"form-group\">\n        <label><strong>Titulo</strong></label>\n        <input type=\"text\" class=\"form-control\" name=\"Titulo\" placeholder=\"Titulo\"");
                BeginWriteAttribute("value", " value=\"", 313, "\"", 334, 1);
#nullable restore
#line 10 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
WriteAttributeValue("", 321, Model.Titulo, 321, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n        <strong style=\"color: #ff0000\">");
#nullable restore
#line 11 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
                                  Write(Html.ValidationMessage("titulo"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n    </div>\n\n\n    <div class=\"form-group\">\n        <label><strong>Contenido</strong></label>\n    </div>\n    <textarea id=\"text\" class=\"form-control\" rows=\"5\" cols=\"60\" name=\"Contenido\"></textarea>\n    <br />\n    <strong style=\"color: #ff0000\"> ");
#nullable restore
#line 20 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
                               Write(Html.ValidationMessage("contenido"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n\n\n    <div class=\"form-group\">\n        <label><strong>Etiquetas</strong></label>\n");
#nullable restore
#line 25 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
         foreach (var item in ViewBag.Etiquetas)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-check form-check\">\n                <input name=\"etiqueta\" class=\"form-check-input\" type=\"checkbox\" id=\"inlineCheckbox1\"");
                BeginWriteAttribute("value", " value=\"", 998, "\"", 1014, 1);
#nullable restore
#line 28 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
WriteAttributeValue("", 1006, item.Id, 1006, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                <label class=\"form-check-label\" for=\"inlineCheckbox1\">");
#nullable restore
#line 29 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
                                                                 Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n            </div>");
#nullable restore
#line 30 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
                  }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <strong style=\"color: #ff0000\">");
#nullable restore
#line 31 "C:\Users\Genesis Granados  R\Desktop\sonarq\T3Calidad-N00024035\T3Calidad-N00024035\Views\Nota\Create.cshtml"
                                  Write(Html.ValidationMessage("etiqueta"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type='text/javascript'>


    var simplemde = new SimpleMDE({
        autofocus: true,
        
        blockStyles: {
            bold: ""__"",
            italic: ""_""
        },
        element: document.getElementById(""text""),
        forceSync: true,
        hideIcons: [""guide"", ""heading""],
        indentWithTabs: false,
       
        insertTexts: {
            horizontalRule: ["""", ""\n\n-----\n\n""],
            image: [""![](http://"", "")""],
            link: [""["", ""](http://)""],
            table: ["""", ""\n\n| Column 1 | Column 2 | Column 3 |\n| -------- | -------- | -------- |\n| Text     | Text      | Text     |\n\n""],
        },
        lineWrapping: false,
        parsingConfig: {
            allowAtxHeaderWithoutSpace: true,
            strikethrough: false,
            underscoresBreakWords: true,
        },
        placeholder: ""Contenido de tu nota..."",
        previewRender: function (plainText) {
            return customMarkdownParser(plainText); 
        },
        previewRender: functi");
            WriteLiteral(@"on (plainText, preview) {
            setTimeout(function () {
                preview.innerHTML = customMarkdownParser(plainText);
            }, 250);

            return ""Loading..."";
        },
        promptURLs: true,
        renderingConfig: {
            singleLineBreaks: false,
            codeSyntaxHighlighting: true,
        },
        shortcuts: {
            drawTable: ""Cmd-Alt-T""
        },
        showIcons: [""code"", ""table""],
        spellChecker: false,
        status: false,
        status: [""autosave"", ""lines"", ""words"", ""cursor""], 
        status: [""autosave"", ""lines"", ""words"", ""cursor"", {
            className: ""keystrokes"",
            defaultValue: function (el) {
                this.keystrokes = 0;
                el.innerHTML = ""0 Keystrokes"";
            },
            onUpdate: function (el) {
                el.innerHTML = ++this.keystrokes + "" Keystrokes"";
            }
        }], 
        styleSelectedText: false,
        tabSize: 4,
        toolbar: [""bold"", ""italic"", ""heading""");
            WriteLiteral(", \"|\", \"quote\"],\n        toolbarTips: false,\n    });\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
