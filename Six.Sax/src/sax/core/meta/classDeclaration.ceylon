/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
namespace six.core.meta;

import six.core.meta.declaration { ClassDeclaration }

"""
Returns the class declaration for a given instance. Since only classes can be instantiated, this will always be a
[[ClassDeclaration]] model.

Using `declaration` can be more efficient than using [[type]] and obtaining the ClassDeclaration from the returned
ClassModel.
"""
shared native ClassDeclaration classDeclaration(Anything instance);