using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "5723b3ded87ab43")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.0.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "contentBase"
	/// <summary>Content Base</summary>
	public partial interface IContentBase : IPublishedContent
	{
		/// <summary>Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		string PageTitle { get; }
	}

	/// <summary>Content Base</summary>
	[PublishedModel("contentBase")]
	public partial class ContentBase : PublishedContentModel, IContentBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "contentBase";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentBase, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentBase(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => GetPageTitle(this);

		/// <summary>Static getter for Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static string GetPageTitle(IContentBase that) => that.Value<string>("pageTitle");
	}

	// Mixin Content Type with alias "metaData"
	/// <summary>Meta Data</summary>
	public partial interface IMetaData : IPublishedContent
	{
		/// <summary>keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		IEnumerable<string> Keywords { get; }

		/// <summary>Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		string SeoMetaDescription { get; }

		/// <summary>Hide in navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		bool UmbNavHide { get; }
	}

	/// <summary>Meta Data</summary>
	[PublishedModel("metaData")]
	public partial class MetaData : PublishedContentModel, IMetaData
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "metaData";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetaData, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public MetaData(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords => GetKeywords(this);

		/// <summary>Static getter for keywords</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static IEnumerable<string> GetKeywords(IMetaData that) => that.Value<IEnumerable<string>>("keywords");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => GetSeoMetaDescription(this);

		/// <summary>Static getter for Description</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static string GetSeoMetaDescription(IMetaData that) => that.Value<string>("seoMetaDescription");

		///<summary>
		/// Hide in navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbNavHide")]
		public bool UmbNavHide => GetUmbNavHide(this);

		/// <summary>Static getter for Hide in navigation</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static bool GetUmbNavHide(IMetaData that) => that.Value<bool>("umbNavHide");
	}

	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IContentBase, IMetaData
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Home(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Carousel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carousel")]
		public IEnumerable<SlideContent> Carousel => this.Value<IEnumerable<SlideContent>>("carousel");

		///<summary>
		/// copyright
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("copyright")]
		public string Copyright => this.Value<string>("copyright");

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("footerDescription")]
		public string FooterDescription => this.Value<string>("footerDescription");

		///<summary>
		/// heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("footerHeading")]
		public string FooterHeading => this.Value<string>("footerHeading");

		///<summary>
		/// Footer Links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("footerLinks")]
		public Umbraco.Web.Models.Link FooterLinks => this.Value<Umbraco.Web.Models.Link>("footerLinks");

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => Umbraco.Web.PublishedModels.ContentBase.GetPageTitle(this);

		///<summary>
		/// keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords => MetaData.GetKeywords(this);

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => MetaData.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbNavHide")]
		public bool UmbNavHide => MetaData.GetUmbNavHide(this);
	}

	// Mixin Content Type with alias "slideHeading"
	/// <summary>Slide Heading</summary>
	public partial interface ISlideHeading : IPublishedContent
	{
		/// <summary>Slide Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		string CarouselHeading { get; }
	}

	/// <summary>Slide Heading</summary>
	[PublishedModel("slideHeading")]
	public partial class SlideHeading : PublishedContentModel, ISlideHeading
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "slideHeading";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideHeading, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SlideHeading(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Slide Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselHeading")]
		public string CarouselHeading => GetCarouselHeading(this);

		/// <summary>Static getter for Slide Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static string GetCarouselHeading(ISlideHeading that) => that.Value<string>("carouselHeading");
	}

	// Mixin Content Type with alias "slideImage"
	/// <summary>Slide Image</summary>
	public partial interface ISlideImage : IPublishedContent
	{
		/// <summary>Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		IPublishedContent CarouselImage { get; }
	}

	/// <summary>Slide Image</summary>
	[PublishedModel("slideImage")]
	public partial class SlideImage : PublishedContentModel, ISlideImage
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "slideImage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideImage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SlideImage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselImage")]
		public IPublishedContent CarouselImage => GetCarouselImage(this);

		/// <summary>Static getter for Image</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static IPublishedContent GetCarouselImage(ISlideImage that) => that.Value<IPublishedContent>("carouselImage");
	}

	// Mixin Content Type with alias "slideText"
	/// <summary>Slide Text</summary>
	public partial interface ISlideText : IPublishedContent
	{
		/// <summary>Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		string CarouselText { get; }
	}

	/// <summary>Slide Text</summary>
	[PublishedModel("slideText")]
	public partial class SlideText : PublishedContentModel, ISlideText
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "slideText";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideText, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SlideText(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselText")]
		public string CarouselText => GetCarouselText(this);

		/// <summary>Static getter for Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static string GetCarouselText(ISlideText that) => that.Value<string>("carouselText");
	}

	/// <summary>Slide Content</summary>
	[PublishedModel("slideContent")]
	public partial class SlideContent : PublishedElementModel, ISlideHeading, ISlideImage, ISlideText
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "slideContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SlideContent(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Slide Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("slideLink")]
		public Umbraco.Web.Models.Link SlideLink => this.Value<Umbraco.Web.Models.Link>("slideLink");

		///<summary>
		/// Slide Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselHeading")]
		public string CarouselHeading => SlideHeading.GetCarouselHeading(this);

		///<summary>
		/// Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselImage")]
		public IPublishedContent CarouselImage => SlideImage.GetCarouselImage(this);

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("carouselText")]
		public string CarouselText => SlideText.GetCarouselText(this);
	}

	/// <summary>Tour</summary>
	[PublishedModel("tour")]
	public partial class Tour : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "tour";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Tour, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Tour(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Hero Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("heroDescription")]
		public IHtmlString HeroDescription => this.Value<IHtmlString>("heroDescription");

		///<summary>
		/// HeroImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("heroImage")]
		public IPublishedContent HeroImage => this.Value<IPublishedContent>("heroImage");

		///<summary>
		/// Hero Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("heroTitle")]
		public string HeroTitle => this.Value<string>("heroTitle");
	}

	/// <summary>Folder</summary>
	[PublishedModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "Folder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Folder(IPublishedContent content)
			: base(content)
		{ }

		// properties
	}

	/// <summary>Image</summary>
	[PublishedModel("Image")]
	public partial class Image : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "Image";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Image(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue UmbracoFile => this.Value<Umbraco.Core.PropertyEditors.ValueConverters.ImageCropperValue>("umbracoFile");

		///<summary>
		/// Height: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoHeight")]
		public int UmbracoHeight => this.Value<int>("umbracoHeight");

		///<summary>
		/// Width: in pixels
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoWidth")]
		public int UmbracoWidth => this.Value<int>("umbracoWidth");
	}

	/// <summary>File</summary>
	[PublishedModel("File")]
	public partial class File : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "File";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public File(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoBytes")]
		public long UmbracoBytes => this.Value<long>("umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension => this.Value<string>("umbracoExtension");

		///<summary>
		/// Upload file
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile => this.Value<string>("umbracoFile");
	}

	/// <summary>Member</summary>
	[PublishedModel("Member")]
	public partial class Member : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const string ModelTypeAlias = "Member";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Member(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Is Approved
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved => this.Value<bool>("umbracoMemberApproved");

		///<summary>
		/// Comments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments => this.Value<string>("umbracoMemberComments");

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public decimal UmbracoMemberFailedPasswordAttempts => this.Value<decimal>("umbracoMemberFailedPasswordAttempts");

		///<summary>
		/// Last Lockout Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public decimal UmbracoMemberLastLockoutDate => this.Value<decimal>("umbracoMemberLastLockoutDate");

		///<summary>
		/// Last Login Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public decimal UmbracoMemberLastLogin => this.Value<decimal>("umbracoMemberLastLogin");

		///<summary>
		/// Last Password Change Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public decimal UmbracoMemberLastPasswordChangeDate => this.Value<decimal>("umbracoMemberLastPasswordChangeDate");

		///<summary>
		/// Is Locked Out
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut => this.Value<bool>("umbracoMemberLockedOut");

		///<summary>
		/// Password Answer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public decimal UmbracoMemberPasswordRetrievalAnswer => this.Value<decimal>("umbracoMemberPasswordRetrievalAnswer");

		///<summary>
		/// Password Question
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.1")]
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public decimal UmbracoMemberPasswordRetrievalQuestion => this.Value<decimal>("umbracoMemberPasswordRetrievalQuestion");
	}

}



// EOF
