// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The StartTranscriptionRequest. </summary>
    public partial class StartTranscriptionRequest
    {
        /// <summary> Initializes a new instance of StartTranscriptionRequest. </summary>
        public StartTranscriptionRequest()
        {
        }

        /// <summary> Defines Locale for the transcription e,g en-US. </summary>
        public string Locale { get; set; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
