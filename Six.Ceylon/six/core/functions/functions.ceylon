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

"The identity function that always returns its argument."
tagged("Functions")
shared Value identity<Value>(Value argument) => argument;

"A `void` function that does nothing."
tagged("Functions")
shared void noop(Anything* arguments) {}
