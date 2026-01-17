\
\ @file gpioc.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOC_DEF

  [ifdef] GPIOC_GPIOC_MODER_DEF
    \
    \ @brief GPIO port C mode register
    \ Address offset: 0x00
    \ Reset value: 0xFC000000
    \
    $1a constant GPIOC_MODE13                   \ [0x1a : 2] Port C configuration I/O pin 13
    $1c constant GPIOC_MODE14                   \ [0x1c : 2] Port C configuration I/O pin 14
    $1e constant GPIOC_MODE15                   \ [0x1e : 2] Port C configuration I/O pin 15 These bits are written by software to configure the I/O mode. Access can be protected by GPIOC SEC15.
  [then]


  [ifdef] GPIOC_GPIOC_OTYPER_DEF
    \
    \ @brief GPIO port C output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_OT13                     \ [0x0d] Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.
    $0e constant GPIOC_OT14                     \ [0x0e] Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.
    $0f constant GPIOC_OT15                     \ [0x0f] Port C configuration I/O pin y These bits are written by software to configure the I/O output type. Access can be protected by GPIOC SECy.
  [then]


  [ifdef] GPIOC_GPIOC_OSPEEDR_DEF
    \
    \ @brief GPIOC port output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $1a constant GPIOC_OSPEED13                 \ [0x1a : 2] Port C configuration I/O pin 13
    $1c constant GPIOC_OSPEED14                 \ [0x1c : 2] Port C configuration I/O pin 14
    $1e constant GPIOC_OSPEED15                 \ [0x1e : 2] Port C configuration I/O pin 15 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOC SEC15. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
  [then]


  [ifdef] GPIOC_GPIOC_PUPDR_DEF
    \
    \ @brief GPIO port C pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $1a constant GPIOC_PUPD13                   \ [0x1a : 2] Port C configuration I/O pin 13
    $1c constant GPIOC_PUPD14                   \ [0x1c : 2] Port C configuration I/O pin 14
    $1e constant GPIOC_PUPD15                   \ [0x1e : 2] Port C configuration I/O pin 15 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOC SEC15.
  [then]


  [ifdef] GPIOC_GPIOC_IDR_DEF
    \
    \ @brief GPIO port C input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_ID13                     \ [0x0d] Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.
    $0e constant GPIOC_ID14                     \ [0x0e] Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.
    $0f constant GPIOC_ID15                     \ [0x0f] Port C input data I/O pin y These bits are read-only. They contain the input value of the corresponding I/O port. Access can be protected by GPIOC SECy.
  [then]


  [ifdef] GPIOC_GPIOC_ODR_DEF
    \
    \ @brief GPIO port C output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_OD13                     \ [0x0d] Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.
    $0e constant GPIOC_OD14                     \ [0x0e] Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.
    $0f constant GPIOC_OD15                     \ [0x0f] Port C output data I/O pin y These bits can be read and written by software. Access can be protected by GPIOC SECy. Note: For atomic bit set/reset, the OD bits can be individually set and/or reset by writing to the GPIOC_BSRR or GPIOC_BRR registers.
  [then]


  [ifdef] GPIOC_GPIOC_BSRR_DEF
    \
    \ @brief GPIO port C bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_BS13                     \ [0x0d] Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
    $0e constant GPIOC_BS14                     \ [0x0e] Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
    $0f constant GPIOC_BS15                     \ [0x0f] Port C set I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
    $1d constant GPIOC_BR13                     \ [0x1d] Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1e constant GPIOC_BR14                     \ [0x1e] Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.
    $1f constant GPIOC_BR15                     \ [0x1f] Port C reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy. Note: If both BSy and BRy are set, BSy has priority.
  [then]


  [ifdef] GPIOC_GPIOC_LCKR_DEF
    \
    \ @brief GPIO port C configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_LCK13                    \ [0x0d] Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
    $0e constant GPIOC_LCK14                    \ [0x0e] Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
    $0f constant GPIOC_LCK15                    \ [0x0f] Port C lock I/O pin y These bits are read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOC SECy.
    $10 constant GPIOC_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access is protected by any GPIOC SECy. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[15:13] WR LCKR[16] = 0 + LCKR[15:13] WR LCKR[16] = 1 + LCKR[15:13] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK[15:13] must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOC_GPIOC_AFRH_DEF
    \
    \ @brief GPIO port C alternate function high register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $14 constant GPIOC_AFSEL13                  \ [0x14 : 4] Alternate function selection for port C I/O pin 13
    $18 constant GPIOC_AFSEL14                  \ [0x18 : 4] Alternate function selection for port C I/O pin 14
    $1c constant GPIOC_AFSEL15                  \ [0x1c : 4] Alternate function selection for port C I/O pin 15 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOC SEC15.
  [then]


  [ifdef] GPIOC_GPIOC_BRR_DEF
    \
    \ @brief GPIO port C bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $0d constant GPIOC_BR13                     \ [0x0d] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
    $0e constant GPIOC_BR14                     \ [0x0e] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
    $0f constant GPIOC_BR15                     \ [0x0f] Port reset I/O pin y These bits are write-only. A read to these bits returns the value 0. Access can be protected by GPIOC SECy.
  [then]


  [ifdef] GPIOC_GPIOC_SECCFGR_DEF
    \
    \ @brief GPIO port C secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $0d constant GPIOC_SEC13                    \ [0x0d] I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0e constant GPIOC_SEC14                    \ [0x0e] I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.
    $0f constant GPIOC_SEC15                    \ [0x0f] I/O pin of port C secure bit enable y These bits are written by software to enabled the security I/O port pin.
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOC_GPIOC_MODER        \ GPIO port C mode register
  $04 constant GPIOC_GPIOC_OTYPER       \ GPIO port C output type register
  $08 constant GPIOC_GPIOC_OSPEEDR      \ GPIOC port output speed register
  $0C constant GPIOC_GPIOC_PUPDR        \ GPIO port C pull-up/pull-down register
  $10 constant GPIOC_GPIOC_IDR          \ GPIO port C input data register
  $14 constant GPIOC_GPIOC_ODR          \ GPIO port C output data register
  $18 constant GPIOC_GPIOC_BSRR         \ GPIO port C bit set/reset register
  $1C constant GPIOC_GPIOC_LCKR         \ GPIO port C configuration lock register
  $24 constant GPIOC_GPIOC_AFRH         \ GPIO port C alternate function high register
  $28 constant GPIOC_GPIOC_BRR          \ GPIO port C bit reset register
  $30 constant GPIOC_GPIOC_SECCFGR      \ GPIO port C secure configuration register

: GPIOC_DEF ; [then]
