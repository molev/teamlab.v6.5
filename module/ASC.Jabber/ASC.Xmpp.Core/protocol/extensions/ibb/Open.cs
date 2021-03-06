// // --------------------------------------------------------------------------------------------------------------------
// // <copyright company="Ascensio System Limited" file="Open.cs">
// //   
// // </copyright>
// // <summary>
// //   (c) Copyright Ascensio System Limited 2008-2012
// // </summary>
// // --------------------------------------------------------------------------------------------------------------------

namespace ASC.Xmpp.Core.protocol.extensions.ibb
{
    /*
        <open sid='mySID' 
            block-size='4096'
            xmlns='http://jabber.org/protocol/ibb'/>
     
       <xs:element name='open'>
         <xs:complexType>
          <xs:simpleContent>
            <xs:extension base='empty'>
              <xs:attribute name='sid' type='xs:string' use='required'/>
              <xs:attribute name='block-size' type='xs:string' use='required'/>
            </xs:extension>
          </xs:simpleContent>
         </xs:complexType>
       </xs:element>
    */

    public class Open : Base
    {
        /// <summary>
        /// </summary>
        public Open()
        {
            TagName = "open";
        }

        /// <summary>
        /// </summary>
        /// <param name="sid"> </param>
        /// <param name="blocksize"> </param>
        public Open(string sid, long blocksize) : this()
        {
            Sid = sid;
            BlockSize = blocksize;
        }

        /// <summary>
        ///   Block size
        /// </summary>
        public long BlockSize
        {
            get { return GetAttributeLong("block-size"); }
            set { SetAttribute("block-size", value); }
        }
    }
}