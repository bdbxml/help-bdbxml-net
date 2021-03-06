﻿using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Figaro    
{
    /// <summary>
    /// An <see cref="XmlDocument"/> is the unit of storage within a
    /// <see cref="Container"/>. A document consists of content, a name, and a
    /// set of metadata attributes.
    /// </summary>
    /// <remarks>
    /// The document content is a byte stream. It must be well-formed XML, but need not be valid.
    /// <para>
    ///     To gain access to the document content, use the <see cref="ToString"/> or <see cref="GetContentAsXmlReader"/> methods.
    /// </para>
    /// <para>
    /// The document name is a unique identifier for the document. The name is specified when the document is first placed
    /// in the container. It can either be explicitly specified by the user, or it can be auto-generated by
    /// Figaro. See <see cref="Container.PutDocument(string,UpdateContext)"/> for details.
    /// </para><para>
    /// The user can retrieve the document by name
    /// using <see cref="Container.GetDocument(string)"/>. In addition, the document name can
    /// be referenced in an XQuery expression using the <c>doc()</c> navigation function.
    /// </para>
    /// 	<example>
    /// Suppose your document's name is
    /// '<c>doc1.xml</c>' and the container that it exists in is '<c>container1.bdbxml</c>'. In this case, you can
    /// explicitly request the document by its name using:
    /// <code>
    /// doc('dbxml:/container1.bdbxml/doc1.xml')
    /// </code>
    /// 	</example>
    /// <para>
    /// The metadata attributes provide a means of associating information with a document, without having to store it within
    /// the document itself. Example metadata attributes might be: document owner, creation time, receipt time, originating source,
    /// final destination, and next processing phase. They are analogous to the attributes of a file in a file system. Each metadata
    /// attribute consists of a name-value pair. The document's name is an implicit metadata attribute.
    /// </para><para>
    /// You can access the metadata for a given document by using
    /// either <see cref="XmlDocument.GetMetadataXmlData(System.String,System.String)"/> or
    /// <see cref="XmlDocument.GetMetadataXmlValue(System.String,System.String)"/>,
    /// or by iterating over the document's metadata. Use <see cref="XmlDocument.GetMetadataIterator"/>
    /// to retrieve a <see cref="XmlMetadataIterator"/> object.
    /// </para><para>
    /// You can instantiate an empty <see cref="XmlDocument"/> object using
    /// <see cref="XmlManager.CreateDocument()"/>. The copy constructor
    /// and assignment operator are provided for this class. The class is implemented using a handle-body idiom. When a handle
    /// is copied both handles maintain a reference to the same body.
    /// </para>
    /// <para>
    /// <alert class="note">
    /// <para>The Figaro <see cref="XmlDocument"/> can be cast as a <see cref="System.Xml.XmlDocument"/> object. For example:</para>
    /// <code lang="C#" title="Casting Figaro XmlDocument to System.Xml.XmlDocument">
    ///     var xmlDoc = figaroDoc as System.Xml.XmlDocument;
    /// </code>
    /// </alert>
    /// </para>
    /// </remarks>
    /// <threadsafety static="false" instance="false"/>
    /// <seealso cref="Container.GetDocument(string)"/>
    /// <seealso cref="XmlManager.CreateDocument()"/>
    /// <seealso cref="XmlMetadataIterator"/>
    public sealed class XmlDocument : IDisposable
    {

        /// <summary>
        /// Get the value of a particular metadata key.
        /// </summary>
        /// <param name="uri">The URI of the metadata value you wish to look up.</param>
        /// <param name="name">The name of the metadata value.</param>
        /// <returns>The <see cref="string"/> value of the metadata item.</returns>
        public string GetMetaData(string uri, string name)
        {
            return null;
        }
        /// <summary>
        /// Return an <see cref="XDocument"/> representation of the contents of the <see cref="XmlDocument"/>.
        /// </summary>
        /// <returns>An <see cref="XDocument"/> instance.</returns>
        public XDocument GetContentAsXDocument()
        {
            return null;
        }
        /// <summary>
        /// Return an <see cref="XDocument"/> using the specified <see cref="LoadOptions"/>.
        /// </summary>
        /// <param name="options">The <see cref="LoadOptions"/> to use.</param>
        /// <returns>An <see cref="XDocument"/> instance.</returns>
        public XDocument GetContentAsXDocument(LoadOptions options)
        {
            return null;
        }


        /// <summary>
        /// Prevents a default instance of the XmlDocument class from being created.
        /// </summary>
        private XmlDocument() {}

        /// <summary>
        /// Fetch all document content and metadata.
        /// </summary>
        /// <remarks>
        /// If a document was retrieved using lazy evaluation,
        /// then document content and metadata is only retrieved from the container on an as-needed basis. This
        /// method causes all document data and metadata to be retrieved. Note that documents in node storage
        /// containers are implicitly lazy.
        /// <para>
        /// Note that if lazy evaluation was not used to
        /// retrieve the document, then use of this method has no significant performance impact. However,
        /// if the document was retrieved lazily, then repeatedly calling this method on any given document
        /// may hurt your application's performance. This is because each time this method is called, Berkeley
        /// DB XML must walk the entire document tree in order to ensure that it has retrieved the entire document.
        /// </para>
        /// </remarks>
        /// <seealso cref="EvaluationType"/>
        /// <seealso cref="GetAllDocumentOptions"/>
        /// <seealso cref="QueryContext.EvaluationType"/>
        /// <seealso cref="XmlManager.CreateQueryContext(Figaro.EvaluationType)"/>
        /// <seealso cref="QueryContext"/>
        public void FetchAllData() {}
        /// <summary>
        /// Returns the specified metadata as an <see cref="XmlValue"/>.
        /// </summary>
        /// <param name="uri">The URI of the metadata to retrieve. An empty string refers to the default namespace.</param>
        /// <param name="name">The name of the metadata attribute.</param>
        /// <returns>
        /// An <see cref="XmlValue"/> containing the metadata value,
        /// or <c>null</c> if the metadata does not exist.
        /// </returns>
        /// <seealso cref="XmlValue"/>
        public XmlValue GetMetadataXmlValue(string uri, string name)
        { 
            return null;
        }
        /// <summary>
        /// Returns the specified metadata as an <see cref="XmlData"/>.
        /// </summary>
        /// <param name="uri">The URI of the metadata to retrieve. An empty string refers to the default namespace.</param>
        /// <param name="name">The name of the metadata attribute.</param>
        /// <returns>
        /// An <see cref="XmlData"/> containing the metadata value,
        /// or <c>null</c> if the metadata does not exist.
        /// </returns>
        /// <seealso cref="XmlData"/>
        public XmlData GetMetadataXmlData(string uri, string name)
        {
            return null;
        }

        /// <summary>
        /// Returns an <see cref="XmlMetadataIterator"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="XmlMetadataIterator"/> for the document.
        /// </returns>
        /// <remarks>
        /// Using this iterator, you can examine the individual metadata items set for the document
        /// by looping over them using <see cref="XmlMetadataIterator.Next"/>.
        /// </remarks>
        /// <seealso cref="XmlMetadataIterator.Next"/>
        /// <seealso cref="XmlMetadataIterator"/>
        public XmlMetadataIterator GetMetadataIterator()
        {
            return null;
        }

        /// <summary>
        /// Return the content of a Figaro <see cref="XmlDocument"/> as a <see cref="TextReader"/>.
        /// </summary>
        /// <returns>A new <see cref="TextReader"/> containing the document contents.</returns>
        public XmlTextReader GetContentAsTextReader()
        {
            return null;
        }

        /// <summary>
        /// Return the content of an <see cref="XmlDocument"/> as an <see cref="XmlReader"/>.
        /// </summary>
        /// <returns>A new <see cref="XmlReader"/> containing the document contents.</returns>
        public XmlReader GetContentAsXmlReader()
        {
            return null;
        }

        /// <summary>
        /// Gets or sets the name of the document.
        /// </summary>
        /// <value>The name of the document.</value>
        /// <remarks>
        /// Note that when the document is put in a container, either the name that you specify must be
        /// unique, or you must use
        /// the <see cref="PutDocumentOptions.GenerateFileName"/> flag, or
        /// an exception is thrown.
        /// </remarks>
        /// <seealso cref="PutDocumentOptions.GenerateFileName"/>
        /// <seealso cref="Container.PutDocument(string,UpdateContext)"/>
        public string Name { get; set; }

        /// <summary>
        /// Removes the identified metadata from the document.
        /// </summary>
        /// <param name="uri">The namespace within which the name resides. An empty string refers to the default namespace.</param>
        /// <param name="name">The name of the metadata attribute to be removed.</param>
        public void RemoveMetadata(string uri, string name) { }

        /// <summary>
        /// Sets the document's content to the provided content.
        /// </summary>
        /// <param name="content">The content for the <see cref="XmlDocument"/>.</param>
        /// <remarks>
        /// If this document is a new document (that is, its name is currently not in use by another
        /// document in the container), you can add it to a container
        /// using <see cref="Container.PutDocument(string,UpdateContext)"/>. If you are
        /// updating an already existing document, you can update the document in the container
        /// using <see cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>.
        /// </remarks>
        /// <seealso cref="Container.PutDocument(string,UpdateContext)"/>
        /// <seealso cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>
        /// <seealso cref="XmlDocument"/>
        public void SetContent(string content) { }
        /// <summary>
        /// Sets the document's content to the
        /// provided <see cref="XmlData"/> content.
        /// </summary>
        /// <param name="content">The content for the <see cref="XmlDocument"/>.</param>
        /// <remarks>
        /// If this document is a new document (that is, its name is currently not in use by another
        /// document in the container), you can add it to a container
        /// using <see cref="Container.PutDocument(string,UpdateContext)"/>. If you are
        /// updating an already existing document, you can update the document in the container
        /// using <see cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>.
        /// </remarks>
        /// <seealso cref="XmlData"/>
        /// <seealso cref="Container.PutDocument(string,UpdateContext)"/>
        /// <seealso cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>
        /// <seealso cref="XmlDocument"/>
        public void SetContent(XmlData content) { }


        /// <summary>
        /// Sets the document's content to the provided <see cref="XmlInputStream"/> content.
        /// </summary>
        /// <param name="stream">The content for the <see cref="XmlDocument"/>.</param>
        /// <remarks>
        /// If this document is a new document (that is, its name is currently not in use by another
        /// document in the container), you can add it to a container
        /// using <see cref="Container.PutDocument(string,UpdateContext)"/>. If you are
        /// updating an already existing document, you can update the document in the container
        /// using <see cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>.
        /// </remarks>
        /// <seealso cref="XmlInputStream"/>
        /// <seealso cref="Container.PutDocument(string,UpdateContext)"/>
        /// <seealso cref="Container.UpdateDocument(Figaro.XmlDocument,Figaro.UpdateContext)"/>
        /// <seealso cref="XmlDocument"/>
        public void SetContentAsInputStream(XmlInputStream stream) { }

        /// <summary>
        /// Sets the untyped <see cref="XmlData"/> value
        /// of the specified metadata attribute.
        /// </summary>
        /// <param name="uri">The namespace within which the name resides. An empty string refers to the default namespace.</param>
        /// <param name="name">The name of the metadata attribute to add.</param>
        /// <param name="value">The untyped metadata value.</param>
        /// <remarks>
        /// A metadata attribute is a name-value pair, which is stored with the document, but not
        /// as part of the document content. 
        /// <para>The value of a metadata attribute may be typed or untyped.</para>
        /// </remarks>
        /// <seealso cref="XmlData"/>
        public void SetMetadata(string uri, string name, XmlData value) { }
        /// <summary>
        /// Sets the typed <see cref="XmlValue"/> value
        /// of the specified metadata attribute.
        /// </summary>
        /// <param name="uri">The namespace within which the name resides. An empty string refers to the default namespace.</param>
        /// <param name="name">The name of the metadata attribute to add.</param>
        /// <param name="value">The typed metadata value.</param>
        /// <remarks>
        /// A metadata attribute is a name-value pair, which is stored with the document, but not
        /// as part of the document content. The value of a metadata attribute may be typed or untyped.
        /// </remarks>
        /// <seealso cref="XmlValue"/>
        public void SetMetadata(string uri, string name, XmlValue value) { }

        /// <summary>
        /// Return the contents of the document as a <see cref="System.String"/>.
        /// </summary>
        /// <returns>The contents of the document.</returns>
        public override string ToString()
        {
            return string.Empty;
        }

        /// <summary>
        /// Transforms a Figaro <see cref="XmlDocument"/> into a <see cref="System.Xml.XmlDocument"/>. 
        /// </summary>
        /// <param name="val">The <see cref="XmlDocument"/> to transform.</param>
        /// <returns></returns>
        public static explicit operator System.Xml.XmlDocument(XmlDocument val)
        {
            return new System.Xml.XmlDocument();    
        }


        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}