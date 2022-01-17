/********************************************************************************
 * Copyright (c) 2011-2017 Red Hat Inc. and/or its affiliates and others
 *
 * This program and the accompanying materials are made available under the 
 * terms of the Apache License, Version 2.0 which is available at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * SPDX-License-Identifier: Apache-2.0 
 ********************************************************************************/
"The `Float` which best approximates the
 mathematical constant \{#0001D452}, the
 base of the natural logarithm."
see(`function exp`,`function log`)
shared Float e = 2.7182818284590452354;

"The Float which best approximates the
 mathematical constant \{#03C0}, the ratio
 of the circumference of a circle to its
 diameter."
shared Float pi = 3.14159265358979323846;

Float undefined = 0.0/0.0;

Float twoFiftyTwo = (2^52).float;