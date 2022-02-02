/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
namespace six.core;

"""
Represents the system on which the current process is executing.

Holds information about system time and locale.
"""
see (value process, value runtime, value language, value operatingSystem)
tagged("Environment")
shared native("jvm") object system
{
    import java.lang { System }
    import java.util { TimeZone, Locale }
    import java.nio.charset { Charset { defaultCharset } }
    
    "The elapsed time in milliseconds since midnight, 1 January 1970."
    shared native("jvm") Integer milliseconds => System.currentTimeMillis();    
    
    "The elapsed time in nanoseconds since an arbitrary starting point."
    shared native("jvm") Integer nanoseconds => System.nanoTime();
    
    "Returns the offset, in milliseconds, to add to UTC to get the local time for default timezone for this system."
    shared native("jvm") Integer timezoneOffset => TimeZone.default.getOffset(milliseconds);
    
    "Returns the IETF language tag representing the default locale for this system."
    shared native("jvm") String locale => Locale.default.toLanguageTag();
    
    "Returns the IANA character set name representing the default character encoding for this system."
    shared native("jvm") String characterEncoding => defaultCharset().name();
    
    shared actual String string => "system";
}
