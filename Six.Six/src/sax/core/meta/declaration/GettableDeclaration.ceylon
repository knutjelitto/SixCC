/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
namespace six.core.meta.declaration;

import ceylon.language.meta.model
{
    Gettable,
    Qualified,
    ValueModel,  
    AppliedType = Type, 
    IncompatibleTypeException, 
    StorageException 
}

"""Abstraction over declarations from which a value can be obtained, namely
 
   * [[ValueDeclaration]] which abstracts over values and attributes 
   * [[ValueConstructorDeclaration]] which represents value constructors
"""
since("1.2.0")
shared sealed interface GettableDeclaration
{    
    "Reads the current value of this toplevel value."
    shared formal Anything get();
    
    "Reads the current value of this attribute on the given container instance."
    throws(class IncompatibleTypeException, "If the specified container is not compatible with this attribute.")
    throws(class StorageException, "If this attribute is not stored at runtime, for example if it is neither shared nor captured.")
    shared formal Anything memberGet(Object container);
    
    "Reads the current value of this `static` attribute."
    shared formal Anything staticGet(AppliedType<Object> containerType);
}