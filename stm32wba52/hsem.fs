\
\ @file hsem.fs
\ @brief Hardware semaphore
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] HSEM_DEF

  [ifdef] HSEM_HSEM_R0_DEF
    \
    \ @brief HSEM register semaphore 0
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R1_DEF
    \
    \ @brief HSEM register semaphore 1
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R2_DEF
    \
    \ @brief HSEM register semaphore 2
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R3_DEF
    \
    \ @brief HSEM register semaphore 3
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R4_DEF
    \
    \ @brief HSEM register semaphore 4
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R5_DEF
    \
    \ @brief HSEM register semaphore 5
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R6_DEF
    \
    \ @brief HSEM register semaphore 6
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R7_DEF
    \
    \ @brief HSEM register semaphore 7
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R8_DEF
    \
    \ @brief HSEM register semaphore 8
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R9_DEF
    \
    \ @brief HSEM register semaphore 9
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R10_DEF
    \
    \ @brief HSEM register semaphore 10
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R11_DEF
    \
    \ @brief HSEM register semaphore 11
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R12_DEF
    \
    \ @brief HSEM register semaphore 12
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R13_DEF
    \
    \ @brief HSEM register semaphore 13
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R14_DEF
    \
    \ @brief HSEM register semaphore 14
    \ Address offset: 0x38
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_R15_DEF
    \
    \ @brief HSEM register semaphore 15
    \ Address offset: 0x3C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore PROCID Written by software -When the semaphore is free and the LOCK is written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition, PROCID is set to the written data. - When the semaphore is unlocked, LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the PROCID is cleared to 0. - When the semaphore is unlocked, LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match the AHB bus master definition, the PROCID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PROCID is not affected. - An authorized read returns the stored PROCID value.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1 and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master protection. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master protection, the LOCKID is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 or AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master protection, the LOCKID is not affected. - Write when LOCK bit is already 1 (semaphore locked), the LOCKID is not affected. - An authorized read returns the stored LOCKID value.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the SEC is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the SEC is not affected. - Write when LOCK bit is already 1 (semaphore locked), the SEC is not affected. - An authorized read returns the stored SEC value.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege Written by software - When the semaphore is free and the LOCK bit is at the same time written to 1, and the LOCKID matches the AHB bus master ID, SEC and PRIV matches the AHB bus master definition. - When the semaphore is unlocked (LOCK written to 0 and AHB bus master ID matched LOCKID, SEC and PRIV matches the AHB bus master definition, the PRIV is cleared to 0. - When the semaphore is unlocked (LOCK bit written to 0 and AHB bus master ID does not match LOCKID and/or SEC or PRIV do not match AHB bus master definition, the PRIV is not affected. - Write when LOCK bit is already 1 (semaphore locked), the PRIV is not affected. - An authorized read returns the stored PRIV value.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit can be written and read by software.
  [then]


  [ifdef] HSEM_HSEM_RLR0_DEF
    \
    \ @brief HSEM read lock register semaphore 0
    \ Address offset: 0x80
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR1_DEF
    \
    \ @brief HSEM read lock register semaphore 1
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR2_DEF
    \
    \ @brief HSEM read lock register semaphore 2
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR3_DEF
    \
    \ @brief HSEM read lock register semaphore 3
    \ Address offset: 0x8C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR4_DEF
    \
    \ @brief HSEM read lock register semaphore 4
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR5_DEF
    \
    \ @brief HSEM read lock register semaphore 5
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR6_DEF
    \
    \ @brief HSEM read lock register semaphore 6
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR7_DEF
    \
    \ @brief HSEM read lock register semaphore 7
    \ Address offset: 0x9C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR8_DEF
    \
    \ @brief HSEM read lock register semaphore 8
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR9_DEF
    \
    \ @brief HSEM read lock register semaphore 9
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR10_DEF
    \
    \ @brief HSEM read lock register semaphore 10
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR11_DEF
    \
    \ @brief HSEM read lock register semaphore 11
    \ Address offset: 0xAC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR12_DEF
    \
    \ @brief HSEM read lock register semaphore 12
    \ Address offset: 0xB0
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR13_DEF
    \
    \ @brief HSEM read lock register semaphore 13
    \ Address offset: 0xB4
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR14_DEF
    \
    \ @brief HSEM read lock register semaphore 14
    \ Address offset: 0xB8
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_RLR15_DEF
    \
    \ @brief HSEM read lock register semaphore 15
    \ Address offset: 0xBC
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PROCID                    \ [0x00 : 8] Semaphore processor ID This field is read only by software at this address. - On a read when the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PROCID to 0. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PROCID of the AHB bus master that has locked the semaphore.
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] Semaphore LOCKID This field is read only by software at this address. On a read, when the semaphore is free, the hardware sets the LOCKID to the AHB bus master ID reading the semaphore. The LOCKID of the AHB bus master locking the semaphore is read. On a read when the semaphore is locked, this field returns the LOCKID of the AHB bus master that has locked the semaphore.
    $0c constant HSEM_SEC                       \ [0x0c] Semaphore secure. This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the SEC to the valid AHB bus master security definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the SEC of the AHB bus master that has locked the semaphore.
    $0d constant HSEM_PRIV                      \ [0x0d] Semaphore privilege This field is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and hardware sets the PRIV to the valid AHB bus master privileged definition. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns the PRIV of the AHB bus master that has locked the semaphore.
    $1f constant HSEM_LOCK                      \ [0x1f] Lock indication This bit is read only by software at this address. - When the semaphore is free: A read with a valid AHB bus master ID and SEC and PRIV locks the semaphore and returns 1. - When the semaphore is locked: A read with a valid AHB bus master ID and SEC and PRIV returns 1 (the LOCKID and SEC and PRIV and PROCID reflect the already locked semaphore information).
  [then]


  [ifdef] HSEM_HSEM_IER_DEF
    \
    \ @brief HSEM non-secure interrupt enable register
    \ Address offset: 0x100
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISE                       \ [0x00 : 16] Non-secure Interrupt semaphore x enable bit This bit is read and written by software. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x is forced to 0 and cannot be accessed, write to this bit is discarded and a read returns 0. When semaphore x PRIVx is disabled, bit x can be accessed with privilege and unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with privileged access. Unprivileged write to this bit is discarded, unprivileged read returns 0.
  [then]


  [ifdef] HSEM_HSEM_ICR_DEF
    \
    \ @brief HSEM non-secure interrupt clear register
    \ Address offset: 0x104
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISC                       \ [0x00 : 16] Non-secure Interrupt semaphore x clear bit This bit is written by software, and is always read 0. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x cannot be accessed, write to this bit is discarded. When semaphore x PRIVx is disabled, bit x can be accessed with privileged and unprivileged access. When semaphore x PRIVx is enabled, bit x can only be accessed with privileged access. Unprivileged write to this bit is discarded.
  [then]


  [ifdef] HSEM_HSEM_ISR_DEF
    \
    \ @brief HSEM non-secure interrupt status register
    \ Address offset: 0x108
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_ISF                       \ [0x00 : 16] Interrupt semaphore x status bit before enable (mask) This bit is set by hardware, and reset only by software. This bit is cleared by software writing the corresponding HSEM_ICR bit.
  [then]


  [ifdef] HSEM_HSEM_MISR_DEF
    \
    \ @brief HSEM non-secure interrupt status register
    \ Address offset: 0x10C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_MISF                      \ [0x00 : 16] Masked non-secure interrupt semaphore x status bit after enable (mask) This bit is set by hardware and read only by software. This bit is cleared by software writing the corresponding HSEM_ICR bit. This bit is read as 0 when semaphore x status is masked in HSEM_IER bit x. When semaphore x SECx is disabled, bit x can be accessed with secure and non-secure access. When semaphore x SECx is enabled, bit x cannot be accessed, read returns 0. When semaphore x PRIVx is disabled, bit x can be accessed with privileged and unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with privileged access. Unprivileged read returns 0.
  [then]


  [ifdef] HSEM_HSEM_SIER_DEF
    \
    \ @brief HSEM secure interrupt enable register
    \ Address offset: 0x180
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_SISE                      \ [0x00 : 16] Secure interrupt semaphore x enable bit This bit is read and written by software. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. secure unprivileged write to this bit is discarded, secure unprivileged read return 0 value.
  [then]


  [ifdef] HSEM_HSEM_SICR_DEF
    \
    \ @brief HSEM secure interrupt clear register
    \ Address offset: 0x184
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_SISC                      \ [0x00 : 16] Secure interrupt semaphore x clear bit This bit is written by software, and is always read 0. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged write to this bit is discarded.
  [then]


  [ifdef] HSEM_HSEM_SISR_DEF
    \
    \ @brief HSEM secure interrupt status register
    \ Address offset: 0x188
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_SISF                      \ [0x00 : 16] Secure interrupt semaphore x status bit before enable (mask) This bit is set by hardware and read only by software. Bit is cleared by software writing the corresponding HSEM_SCnICR bit x. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged read return 0 value.
  [then]


  [ifdef] HSEM_HSEM_MSISR_DEF
    \
    \ @brief HSEM secure masked interrupt status register
    \ Address offset: 0x18C
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_SMISF                     \ [0x00 : 16] Secure masked interrupt semaphore x status bit after enable (mask) This bit is set by hardware and read only by software. Bit is cleared by software writing the corresponding HSEM_SCnICR bit x. Bit is read as 0 when semaphore x status is masked in HSEM_SCnIER bit x. When semaphore x PRIVx is disabled, bit x can be accessed with secure privilege and secure unprivileged access. When semaphore x PRIVx is enabled, bit x can be accessed only with secure privilege access. Secure unprivileged read return 0 value.
  [then]


  [ifdef] HSEM_HSEM_SECCFGR_DEF
    \
    \ @brief HSEM security configuration register
    \ Address offset: 0x200
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_SEC                       \ [0x00 : 16] Semaphore x security attribute This bit is set and cleared by software.
  [then]


  [ifdef] HSEM_HSEM_PRIVCFGR_DEF
    \
    \ @brief HSEM privilege configuration register
    \ Address offset: 0x210
    \ Reset value: 0x00000000
    \
    $00 constant HSEM_PRIV                      \ [0x00 : 16] Semaphore x privilege attribute This bit is set and cleared by software. When semaphore x SECx is disabled, bit x can be write accessed with secure privileged and non-secure privileged access. When semaphore x SECx is enabled, bit x can only be write accessed with secure privilege access. Non-secure privileged write access is discarded. Both secure and non-secure read return the register bit x value
  [then]


  [ifdef] HSEM_HSEM_CR_DEF
    \
    \ @brief HSEM clear register
    \ Address offset: 0x230
    \ Reset value: 0x00000000
    \
    $08 constant HSEM_LOCKID                    \ [0x08 : 4] LOCKID of semaphores to be cleared This field can be written by software and is always read 0. This field indicates the LOCKID for which the semaphores are cleared when writing the HSEM_CR.
    $0c constant HSEM_SEC                       \ [0x0c] SEC value of semaphores to be cleared. This field can be written by software, is always read 0. Indicates the SEC for which the CID semaphores are cleared when writing the HSEM_CR
    $0d constant HSEM_PRIV                      \ [0x0d] PRIV value of semaphores to be cleared. This field can be written by software, is always read 0. Indicates the PRIV for which the CID semaphores are cleared when writing the HSEM_CR.
    $10 constant HSEM_KEY                       \ [0x10 : 16] Semaphore clear key This field can be written by software and is always read 0. If this key value does not match HSEM_KEYR.KEY, semaphores are not affected. If this key value matches HSEM_KEYR.KEY, all semaphores matching the LOCKID are cleared to the free state.
  [then]


  [ifdef] HSEM_HSEM_KEYR_DEF
    \
    \ @brief HSEM interrupt clear register
    \ Address offset: 0x234
    \ Reset value: 0x00000000
    \
    $10 constant HSEM_KEY                       \ [0x10 : 16] Semaphore clear key This field can be written and read by software. Key value to match when clearing semaphores.
  [then]

  \
  \ @brief Hardware semaphore
  \
  $00 constant HSEM_HSEM_R0             \ HSEM register semaphore 0
  $04 constant HSEM_HSEM_R1             \ HSEM register semaphore 1
  $08 constant HSEM_HSEM_R2             \ HSEM register semaphore 2
  $0C constant HSEM_HSEM_R3             \ HSEM register semaphore 3
  $10 constant HSEM_HSEM_R4             \ HSEM register semaphore 4
  $14 constant HSEM_HSEM_R5             \ HSEM register semaphore 5
  $18 constant HSEM_HSEM_R6             \ HSEM register semaphore 6
  $1C constant HSEM_HSEM_R7             \ HSEM register semaphore 7
  $20 constant HSEM_HSEM_R8             \ HSEM register semaphore 8
  $24 constant HSEM_HSEM_R9             \ HSEM register semaphore 9
  $28 constant HSEM_HSEM_R10            \ HSEM register semaphore 10
  $2C constant HSEM_HSEM_R11            \ HSEM register semaphore 11
  $30 constant HSEM_HSEM_R12            \ HSEM register semaphore 12
  $34 constant HSEM_HSEM_R13            \ HSEM register semaphore 13
  $38 constant HSEM_HSEM_R14            \ HSEM register semaphore 14
  $3C constant HSEM_HSEM_R15            \ HSEM register semaphore 15
  $80 constant HSEM_HSEM_RLR0           \ HSEM read lock register semaphore 0
  $84 constant HSEM_HSEM_RLR1           \ HSEM read lock register semaphore 1
  $88 constant HSEM_HSEM_RLR2           \ HSEM read lock register semaphore 2
  $8C constant HSEM_HSEM_RLR3           \ HSEM read lock register semaphore 3
  $90 constant HSEM_HSEM_RLR4           \ HSEM read lock register semaphore 4
  $94 constant HSEM_HSEM_RLR5           \ HSEM read lock register semaphore 5
  $98 constant HSEM_HSEM_RLR6           \ HSEM read lock register semaphore 6
  $9C constant HSEM_HSEM_RLR7           \ HSEM read lock register semaphore 7
  $A0 constant HSEM_HSEM_RLR8           \ HSEM read lock register semaphore 8
  $A4 constant HSEM_HSEM_RLR9           \ HSEM read lock register semaphore 9
  $A8 constant HSEM_HSEM_RLR10          \ HSEM read lock register semaphore 10
  $AC constant HSEM_HSEM_RLR11          \ HSEM read lock register semaphore 11
  $B0 constant HSEM_HSEM_RLR12          \ HSEM read lock register semaphore 12
  $B4 constant HSEM_HSEM_RLR13          \ HSEM read lock register semaphore 13
  $B8 constant HSEM_HSEM_RLR14          \ HSEM read lock register semaphore 14
  $BC constant HSEM_HSEM_RLR15          \ HSEM read lock register semaphore 15
  $100 constant HSEM_HSEM_IER           \ HSEM non-secure interrupt enable register
  $104 constant HSEM_HSEM_ICR           \ HSEM non-secure interrupt clear register
  $108 constant HSEM_HSEM_ISR           \ HSEM non-secure interrupt status register
  $10C constant HSEM_HSEM_MISR          \ HSEM non-secure interrupt status register
  $180 constant HSEM_HSEM_SIER          \ HSEM secure interrupt enable register
  $184 constant HSEM_HSEM_SICR          \ HSEM secure interrupt clear register
  $188 constant HSEM_HSEM_SISR          \ HSEM secure interrupt status register
  $18C constant HSEM_HSEM_MSISR         \ HSEM secure masked interrupt status register
  $200 constant HSEM_HSEM_SECCFGR       \ HSEM security configuration register
  $210 constant HSEM_HSEM_PRIVCFGR      \ HSEM privilege configuration register
  $230 constant HSEM_HSEM_CR            \ HSEM clear register
  $234 constant HSEM_HSEM_KEYR          \ HSEM interrupt clear register

: HSEM_DEF ; [then]
