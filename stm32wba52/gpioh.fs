\
\ @file gpioh.fs
\ @brief General-purpose I/Os
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] GPIOH_DEF

  [ifdef] GPIOH_GPIOH_MODER_DEF
    \
    \ @brief GPIO port H mode register
    \ Address offset: 0x00
    \ Reset value: 0x0000C000
    \
    $06 constant GPIOH_MODE3                    \ [0x06 : 2] Port H configuration I/O pin 3 These bits are written by software to configure the I/O mode. Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_OTYPER_DEF
    \
    \ @brief GPIO port H output type register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_OT3                      \ [0x03] Port H configuration I/O pin 3 This bit is written by software to configure the I/O output type. Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_OSPEEDR_DEF
    \
    \ @brief GPIO port H output speed register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $06 constant GPIOH_OSPEED3                  \ [0x06 : 2] Port H configuration I/O pin 3 These bits are written by software to configure the I/O output speed. Access can be protected by GPIOH SEC3. Note: Refer to the device datasheet for the frequency specifications and the power supply and load conditions for each speed.
  [then]


  [ifdef] GPIOH_GPIOH_PUPDR_DEF
    \
    \ @brief GPIO port H pull-up/pull-down register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $06 constant GPIOH_PUPD3                    \ [0x06 : 2] Port H configuration I/O pin 3 These bits are written by software to configure the I/O pull-up or pull-down Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_IDR_DEF
    \
    \ @brief GPIO port H input data register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_ID3                      \ [0x03] Port H input data I/O pin 3 This bit is read-only. It contain the input value of the corresponding I/O port. Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_ODR_DEF
    \
    \ @brief GPIO port H output data register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_OD3                      \ [0x03] Port H output data I/O pin 3 This bits can be read and written by software. Access can be protected by GPIOH SEC3. Note: For atomic bit set/reset, the OD bit can be individually set and/or reset by writing to the GPIOH_BSRR or GPIOH_BRR registers.
  [then]


  [ifdef] GPIOH_GPIOH_BSRR_DEF
    \
    \ @brief GPIO port H bit set/reset register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_BS3                      \ [0x03] Port H set I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3.
    $13 constant GPIOH_BR3                      \ [0x13] Port H reset I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3. Note: If both BS3 and BR3 are set, BS3 has priority.
  [then]


  [ifdef] GPIOH_GPIOH_LCKR_DEF
    \
    \ @brief GPIO port H configuration lock register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_LCK3                     \ [0x03] Port H lock I/O pin 3 This bit is read/write but can only be written when the LCKK bit is 0 Access can be protected by GPIOH SEC3.
    $10 constant GPIOH_LCKK                     \ [0x10] Lock key This bit can be read any time. It can only be modified using the lock key write sequence. Access is protected by GPIOH SEC3. - LOCK key write sequence: WR LCKR[16] = 1 + LCKR[3] WR LCKR[16] = 0 + LCKR[3] WR LCKR[16] = 1 + LCKR[3] - LOCK key read RD LCKR[16] = 1 (this read operation is optional but it confirms that the lock is active) Note: During the LOCK key write sequence, the value of LCK3 must not change. Note: Any error in the lock sequence aborts the LOCK. Note: After the first LOCK sequence on any bit of the port, any read access on the LCKK bit returns 1 until the next MCU reset or peripheral reset.
  [then]


  [ifdef] GPIOH_GPIOH_AFRL_DEF
    \
    \ @brief GPIO port H alternate function low register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $0c constant GPIOH_AFSEL3                   \ [0x0c : 4] Alternate function selection for port H I/O pin 3 These bits are written by software to configure alternate function I/Os. Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_BRR_DEF
    \
    \ @brief GPIO port H bit reset register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $03 constant GPIOH_BR3                      \ [0x03] Port H reset I/O pin 3 This bit is write-only. A read to this bit returns the value 0. Access can be protected by GPIOH SEC3.
  [then]


  [ifdef] GPIOH_GPIOH_SECCFGR_DEF
    \
    \ @brief GPIO port H secure configuration register
    \ Address offset: 0x30
    \ Reset value: 0x0000FFFF
    \
    $03 constant GPIOH_SEC3                     \ [0x03] I/O pin of port H secure bit enable 3 This bit is written by software to enabled the security I/O port pin.
  [then]

  \
  \ @brief General-purpose I/Os
  \
  $00 constant GPIOH_GPIOH_MODER        \ GPIO port H mode register
  $04 constant GPIOH_GPIOH_OTYPER       \ GPIO port H output type register
  $08 constant GPIOH_GPIOH_OSPEEDR      \ GPIO port H output speed register
  $0C constant GPIOH_GPIOH_PUPDR        \ GPIO port H pull-up/pull-down register
  $10 constant GPIOH_GPIOH_IDR          \ GPIO port H input data register
  $14 constant GPIOH_GPIOH_ODR          \ GPIO port H output data register
  $18 constant GPIOH_GPIOH_BSRR         \ GPIO port H bit set/reset register
  $1C constant GPIOH_GPIOH_LCKR         \ GPIO port H configuration lock register
  $20 constant GPIOH_GPIOH_AFRL         \ GPIO port H alternate function low register
  $28 constant GPIOH_GPIOH_BRR          \ GPIO port H bit reset register
  $30 constant GPIOH_GPIOH_SECCFGR      \ GPIO port H secure configuration register

: GPIOH_DEF ; [then]
