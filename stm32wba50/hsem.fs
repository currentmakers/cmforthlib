\
\ @file hsem.fs
\ @brief Hardware semaphore
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief HSEM register semaphore 0
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R0_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R0_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R0_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R0_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R0_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 1
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R1_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R1_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R1_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R1_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R1_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R2_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R2_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R2_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R2_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R2_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 3
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R3_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R3_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R3_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R3_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R3_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 4
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R4_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R4_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R4_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R4_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R4_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 5
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R5_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R5_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R5_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R5_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R5_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 6
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R6_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R6_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R6_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R6_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R6_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 7
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R7_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R7_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R7_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R7_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R7_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 8
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R8_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R8_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R8_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R8_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R8_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 9
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R9_PROCID                              \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R9_LOCKID                              \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R9_SEC                                 \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R9_PRIV                                \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R9_LOCK                                \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 10
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R10_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R10_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R10_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R10_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R10_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 11
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R11_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R11_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R11_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R11_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R11_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 12
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R12_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R12_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R12_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R12_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R12_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 13
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R13_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R13_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R13_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R13_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R13_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 14
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R14_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R14_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R14_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R14_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R14_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM register semaphore 15
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_R15_PROCID                             \ Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
$00000f00 constant HSEM_HSEM_R15_LOCKID                             \ Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
$00001000 constant HSEM_HSEM_R15_SEC                                \ Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
$00002000 constant HSEM_HSEM_R15_PRIV                               \ Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
$80000000 constant HSEM_HSEM_R15_LOCK                               \ Lock indication This bit can be written and read by software.


\
\ @brief HSEM read lock register semaphore 0
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR0_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR0_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR0_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR0_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR0_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 1
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR1_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR1_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR1_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR1_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR1_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 2
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR2_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR2_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR2_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR2_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR2_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 3
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR3_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR3_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR3_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR3_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR3_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 4
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR4_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR4_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR4_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR4_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR4_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 5
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR5_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR5_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR5_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR5_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR5_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 6
\ Address offset: 0x98
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR6_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR6_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR6_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR6_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR6_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 7
\ Address offset: 0x9C
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR7_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR7_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR7_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR7_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR7_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 8
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR8_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR8_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR8_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR8_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR8_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 9
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR9_PROCID                            \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR9_LOCKID                            \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR9_SEC                               \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR9_PRIV                              \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR9_LOCK                              \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 10
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR10_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR10_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR10_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR10_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR10_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 11
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR11_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR11_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR11_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR11_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR11_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 12
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR12_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR12_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR12_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR12_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR12_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 13
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR13_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR13_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR13_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR13_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR13_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 14
\ Address offset: 0xB8
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR14_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR14_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR14_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR14_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR14_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM read lock register semaphore 15
\ Address offset: 0xBC
\ Reset value: 0x00000000
\

$000000ff constant HSEM_HSEM_RLR15_PROCID                           \ Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
$00000f00 constant HSEM_HSEM_RLR15_LOCKID                           \ Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
$00001000 constant HSEM_HSEM_RLR15_SEC                              \ Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
$00002000 constant HSEM_HSEM_RLR15_PRIV                             \ Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
$80000000 constant HSEM_HSEM_RLR15_LOCK                             \ Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).


\
\ @brief HSEM non-secure interrupt enable register
\ Address offset: 0x100
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_IER_ISE                                \ Non-secure Interrupt semaphore x enable bit This bit is read and written by software. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x is forced to 0 and cannot be accessed, write to this bit is discarded and a read returns 0. When semaphore x PRIVx is disabled, bit x can be accessed with privilege and unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with privileged access. Unprivileged write to this bit is discarded, unprivileged read returns 0.


\
\ @brief HSEM non-secure interrupt clear register
\ Address offset: 0x104
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_ICR_ISC                                \ Non-secure Interrupt semaphore x clear bit This bit is written by software, and is always read 0. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x cannot be accessed, write to this bit is discarded. When semaphore x PRIVx is disabled, bit x can be accessed with privileged and unprivileged access. When semaphore x PRIVx is enabled, bit x can only be accessed with privileged access. Unprivileged write to this bit is discarded.


\
\ @brief HSEM non-secure interrupt status register
\ Address offset: 0x108
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_ISR_ISF                                \ Interrupt semaphore x status bit before enable (mask) This bit is set by hardware, and reset only by software. This bit is cleared by software writing the corresponding HSEM_ICR bit.


\
\ @brief HSEM non-secure interrupt status register
\ Address offset: 0x10C
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_MISR_MISF                              \ Masked non-secure interrupt semaphore x status bit after enable (mask) This bit is set by hardware and read only by software. This bit is cleared by software writing the corresponding HSEM_ICR bit. This bit is read as 0 when semaphore x status is masked in HSEM_IER bit x. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x cannot be accessed, read returns 0. When semaphore x PRIVx is disabled, bit x can be accessed with privileged and unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with privileged access. Unprivileged read returns 0.


\
\ @brief HSEM secure interrupt enable register
\ Address offset: 0x180
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_SIER_SISE                              \ Secure interrupt semaphore x enable bit This bit is read and written by software. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. secure unprivileged write to this bit is discarded, secure unprivileged read return 0 value.


\
\ @brief HSEM secure interrupt clear register
\ Address offset: 0x184
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_SICR_SISC                              \ Secure interrupt semaphore x clear bit This bit is written by software, and is always read 0. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged write to this bit is discarded.


\
\ @brief HSEM secure interrupt status register
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_SISR_SISF                              \ Secure interrupt semaphore x status bit before enable (mask) This bit is set by hardware and read only by software. Bit is cleared by software writing the corresponding HSEM_SCnICR bit x. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged read return 0 value.


\
\ @brief HSEM secure masked interrupt status register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_MSISR_SMISF                            \ Secure masked interrupt semaphore x status bit after enable (mask) This bit is set by hardware and read only by software. Bit is cleared by software writing the corresponding HSEM_SCnICR bit x. Bit is read as 0 when semaphore x status is masked in HSEM_SCnIER bit x. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged read return 0 value.


\
\ @brief HSEM security configuration register
\ Address offset: 0x200
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_SECCFGR_SEC                            \ Semaphore x security attribute This bit is set and cleared by software.


\
\ @brief HSEM privilege configuration register
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000ffff constant HSEM_HSEM_PRIVCFGR_PRIV                          \ Semaphore x privilege attribute This bit is set and cleared by software. When semaphore x SECx is disabled, bit x can be write accessed with secure privileged and non-secure privileged access. When semaphore x SECx is enabled, bit x can only be write accessed with secure privilege access. Non-secure privileged write access is discarded. Both secure and non-secure read return the register bit x value


\
\ @brief HSEM clear register
\ Address offset: 0x230
\ Reset value: 0x00000000
\

$00000f00 constant HSEM_HSEM_CR_LOCKID                              \ LOCKID of semaphores to be cleared This field can be written by software and is always read 0. This field indicates the LOCKID for which the semaphores are cleared when writing the HSEM_CR.
$00001000 constant HSEM_HSEM_CR_SEC                                 \ SEC value of semaphores to be cleared. This field can be written by software, is always read 0. Indicates the SEC for which the CID semaphores are cleared when writing the HSEM_CR
$00002000 constant HSEM_HSEM_CR_PRIV                                \ PRIV value of semaphores to be cleared. This field can be written by software, is always read 0. Indicates the PRIV for which the CID semaphores are cleared when writing the HSEM_CR.
$ffff0000 constant HSEM_HSEM_CR_KEY                                 \ Semaphore clear key This field can be written by software and is always read 0. If this key value does not match HSEM_KEYR.KEY, semaphores are not affected. If this key value matches HSEM_KEYR.KEY, all semaphores matching the LOCKID are cleared to the free state.


\
\ @brief HSEM interrupt clear register
\ Address offset: 0x234
\ Reset value: 0x00000000
\

$ffff0000 constant HSEM_HSEM_KEYR_KEY                               \ Semaphore clear key This field can be written and read by software. Key value to match when clearing semaphores.


\
\ @brief Hardware semaphore
\
$420c1c00 constant HSEM_HSEM_R0   \ offset: 0x00 : HSEM register semaphore 0
$420c1c04 constant HSEM_HSEM_R1   \ offset: 0x04 : HSEM register semaphore 1
$420c1c08 constant HSEM_HSEM_R2   \ offset: 0x08 : HSEM register semaphore 2
$420c1c0c constant HSEM_HSEM_R3   \ offset: 0x0C : HSEM register semaphore 3
$420c1c10 constant HSEM_HSEM_R4   \ offset: 0x10 : HSEM register semaphore 4
$420c1c14 constant HSEM_HSEM_R5   \ offset: 0x14 : HSEM register semaphore 5
$420c1c18 constant HSEM_HSEM_R6   \ offset: 0x18 : HSEM register semaphore 6
$420c1c1c constant HSEM_HSEM_R7   \ offset: 0x1C : HSEM register semaphore 7
$420c1c20 constant HSEM_HSEM_R8   \ offset: 0x20 : HSEM register semaphore 8
$420c1c24 constant HSEM_HSEM_R9   \ offset: 0x24 : HSEM register semaphore 9
$420c1c28 constant HSEM_HSEM_R10  \ offset: 0x28 : HSEM register semaphore 10
$420c1c2c constant HSEM_HSEM_R11  \ offset: 0x2C : HSEM register semaphore 11
$420c1c30 constant HSEM_HSEM_R12  \ offset: 0x30 : HSEM register semaphore 12
$420c1c34 constant HSEM_HSEM_R13  \ offset: 0x34 : HSEM register semaphore 13
$420c1c38 constant HSEM_HSEM_R14  \ offset: 0x38 : HSEM register semaphore 14
$420c1c3c constant HSEM_HSEM_R15  \ offset: 0x3C : HSEM register semaphore 15
$420c1c80 constant HSEM_HSEM_RLR0  \ offset: 0x80 : HSEM read lock register semaphore 0
$420c1c84 constant HSEM_HSEM_RLR1  \ offset: 0x84 : HSEM read lock register semaphore 1
$420c1c88 constant HSEM_HSEM_RLR2  \ offset: 0x88 : HSEM read lock register semaphore 2
$420c1c8c constant HSEM_HSEM_RLR3  \ offset: 0x8C : HSEM read lock register semaphore 3
$420c1c90 constant HSEM_HSEM_RLR4  \ offset: 0x90 : HSEM read lock register semaphore 4
$420c1c94 constant HSEM_HSEM_RLR5  \ offset: 0x94 : HSEM read lock register semaphore 5
$420c1c98 constant HSEM_HSEM_RLR6  \ offset: 0x98 : HSEM read lock register semaphore 6
$420c1c9c constant HSEM_HSEM_RLR7  \ offset: 0x9C : HSEM read lock register semaphore 7
$420c1ca0 constant HSEM_HSEM_RLR8  \ offset: 0xA0 : HSEM read lock register semaphore 8
$420c1ca4 constant HSEM_HSEM_RLR9  \ offset: 0xA4 : HSEM read lock register semaphore 9
$420c1ca8 constant HSEM_HSEM_RLR10  \ offset: 0xA8 : HSEM read lock register semaphore 10
$420c1cac constant HSEM_HSEM_RLR11  \ offset: 0xAC : HSEM read lock register semaphore 11
$420c1cb0 constant HSEM_HSEM_RLR12  \ offset: 0xB0 : HSEM read lock register semaphore 12
$420c1cb4 constant HSEM_HSEM_RLR13  \ offset: 0xB4 : HSEM read lock register semaphore 13
$420c1cb8 constant HSEM_HSEM_RLR14  \ offset: 0xB8 : HSEM read lock register semaphore 14
$420c1cbc constant HSEM_HSEM_RLR15  \ offset: 0xBC : HSEM read lock register semaphore 15
$420c1d00 constant HSEM_HSEM_IER  \ offset: 0x100 : HSEM non-secure interrupt enable register
$420c1d04 constant HSEM_HSEM_ICR  \ offset: 0x104 : HSEM non-secure interrupt clear register
$420c1d08 constant HSEM_HSEM_ISR  \ offset: 0x108 : HSEM non-secure interrupt status register
$420c1d0c constant HSEM_HSEM_MISR  \ offset: 0x10C : HSEM non-secure interrupt status register
$420c1d80 constant HSEM_HSEM_SIER  \ offset: 0x180 : HSEM secure interrupt enable register
$420c1d84 constant HSEM_HSEM_SICR  \ offset: 0x184 : HSEM secure interrupt clear register
$420c1d88 constant HSEM_HSEM_SISR  \ offset: 0x188 : HSEM secure interrupt status register
$420c1d8c constant HSEM_HSEM_MSISR  \ offset: 0x18C : HSEM secure masked interrupt status register
$420c1e00 constant HSEM_HSEM_SECCFGR  \ offset: 0x200 : HSEM security configuration register
$420c1e10 constant HSEM_HSEM_PRIVCFGR  \ offset: 0x210 : HSEM privilege configuration register
$420c1e30 constant HSEM_HSEM_CR   \ offset: 0x230 : HSEM clear register
$420c1e34 constant HSEM_HSEM_KEYR  \ offset: 0x234 : HSEM interrupt clear register

