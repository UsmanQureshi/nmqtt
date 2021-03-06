﻿/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://wiki.github.com/markallanson/nmqtt
 * 
 * Copyright (c) 2009-2013 Mark Allanson (mark@markallanson.net) & Contributors
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/
using System;
using Nmqtt;
using Xunit;

namespace NmqttTests {
    /// <summary>
    /// Tests that exercise the additional valiations around topics
    /// that are published from the client.
    /// </summary>
    public class PublicationTopicTests 
    {
        [Fact]
        public void TopicWithWildcardThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => new PublicationTopic("finance/+/closingprice"));
        }
        
        [Fact]
        public void TopicWithMultiWildcardThrowsArgumentException() {
            Assert.Throws<ArgumentException>(() => new PublicationTopic("finance/ibm/#"));
        }        
        
        [Fact]
        public void TopicWithNoWildcardsIsCreatedSuccessfully() {
            Assert.DoesNotThrow(() => new PublicationTopic("finance/ibm/closingprice"));
        }
    }
}
