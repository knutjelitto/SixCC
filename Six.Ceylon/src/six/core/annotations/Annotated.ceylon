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

import six.core { AnnotationType = Annotation }

"A program element that can be annotated."
see(interface Annotation)
shared interface Annotated
{
    "true if this element has at least one annotation of the given annotation type."
    shared formal Boolean annotated<Annotation>() given Annotation satisfies AnnotationType;
}