//
// CmisUpdatability.cs
//
// Author:
//       Dannys Janssen
//
// Copyright (c) 2017 Dannys Janssen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace Cmis.Infrastructure
{
	/// <summary>
	/// CMIS updatability. Indicates under what circumstances the value of a property MAY be updated.
	/// </summary>
	public enum CmisUpdatability
    {
		/// <summary>
		/// The value of this property MUST NOT ever be set directly by an application. 
        /// It is a system property that is either maintained or computed by the repository. 
        /// The value of a read-only property MAY be indirectly modiﬁed by other repository interactions 
        /// (for example, calling updateProperties on an object will change the object’s last modiﬁed date, 
        /// even though that property cannot be directly set via an updateProperties service call.) 
		/// </summary>
        [CmisName(Constants.CmisUpdatabilityReadOnly)]
		ReadOnly,
		/// <summary>
		/// The property value can be modiﬁed using the updateProperties service.
		/// </summary>
        [CmisName(Constants.CmisUpdatabilityReadWrite)]
		ReadWrite,
		/// <summary>
		/// The property value MUST only be update-able using a "private working copy" document. That is, the update is either made on a "private working copy" object or made using the checkIn service.
		/// </summary>
        [CmisName(Constants.CmisUpdatabilityWhenCheckedOut)]
		WhenCheckedOut,
		/// <summary>
		/// The property value MUST only be update-able during the create operation on that object.
		/// </summary>
        [CmisName(Constants.CmisUpdatabilityOnCreate)]
		OnCreate
    }
}
