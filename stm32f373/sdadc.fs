\
\ @file sdadc.fs
\ @brief Sigma-delta analog-to-digital converter
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] SDADC_DEF

  [ifdef] SDADC_CR1_DEF
    \
    \ @brief control register 1
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_EOCALIE                  \ [0x00] End of calibration interrupt enable
    $01 constant SDADC_JEOCIE                   \ [0x01] Injected end of conversion interrupt enable
    $02 constant SDADC_JOVRIE                   \ [0x02] Injected data overrun interrupt enable
    $03 constant SDADC_REOCIE                   \ [0x03] Regular end of conversion interrupt enable
    $04 constant SDADC_ROVRIE                   \ [0x04] Regular data overrun interrupt enable
    $08 constant SDADC_REFV                     \ [0x08 : 2] Reference voltage selection
    $0a constant SDADC_SLOWCK                   \ [0x0a] Slow clock mode enable
    $0b constant SDADC_SBI                      \ [0x0b] Enter Standby mode when idle
    $0c constant SDADC_PDI                      \ [0x0c] Enter power down mode when idle
    $0e constant SDADC_JSYNC                    \ [0x0e] Launch a injected conversion synchronously with SDADC1
    $0f constant SDADC_RSYNC                    \ [0x0f] Launch regular conversion synchronously with SDADC1
    $10 constant SDADC_JDMAEN                   \ [0x10] DMA channel enabled to read data for the injected channel group
    $11 constant SDADC_RDMAEN                   \ [0x11] DMA channel enabled to read data for the regular channel
    $1f constant SDADC_INIT                     \ [0x1f] Initialization mode request
  [then]


  [ifdef] SDADC_CR2_DEF
    \
    \ @brief control register 2
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_ADON                     \ [0x00] SDADC enable
    $01 constant SDADC_CALIBCNT                 \ [0x01 : 2] Number of calibration sequences to be performed (number of valid configurations)
    $04 constant SDADC_STARTCALIB               \ [0x04] Start calibration
    $05 constant SDADC_JCONT                    \ [0x05] Continuous mode selection for injected conversions
    $06 constant SDADC_JDS                      \ [0x06] Delay start of injected conversions.
    $08 constant SDADC_JEXTSEL                  \ [0x08 : 4] Trigger signal selection for launching injected conversions
    $0d constant SDADC_JEXTEN                   \ [0x0d : 2] Trigger enable and trigger edge selection for injected conversions
    $0f constant SDADC_JSWSTART                 \ [0x0f] Start a conversion of the injected group of channels
    $10 constant SDADC_RCH                      \ [0x10 : 4] Regular channel selection
    $16 constant SDADC_RCONT                    \ [0x16] Continuous mode selection for regular conversions
    $17 constant SDADC_RSWSTART                 \ [0x17] Software start of a conversion on the regular channel
    $18 constant SDADC_FAST                     \ [0x18] Fast conversion mode selection
  [then]


  [ifdef] SDADC_ISR_DEF
    \
    \ @brief interrupt and status register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_EOCALF                   \ [0x00] End of calibration flag
    $01 constant SDADC_JEOCF                    \ [0x01] End of injected conversion flag
    $02 constant SDADC_JOVRF                    \ [0x02] Injected conversion overrun flag
    $03 constant SDADC_REOCF                    \ [0x03] End of regular conversion flag
    $04 constant SDADC_ROVRF                    \ [0x04] Regular conversion overrun flag
    $0c constant SDADC_CALIBIP                  \ [0x0c] Calibration in progress status
    $0d constant SDADC_JCIP                     \ [0x0d] Injected conversion in progress status
    $0e constant SDADC_RCIP                     \ [0x0e] Regular conversion in progress status
    $0f constant SDADC_STABIP                   \ [0x0f] Stabilization in progress status
    $1f constant SDADC_INITRDY                  \ [0x1f] Initialization mode is ready
  [then]


  [ifdef] SDADC_CLRISR_DEF
    \
    \ @brief interrupt and status clear register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_CLREOCALF                \ [0x00] Clear the end of calibration flag
    $02 constant SDADC_CLRJOVRF                 \ [0x02] Clear the injected conversion overrun flag
    $04 constant SDADC_CLRROVRF                 \ [0x04] Clear the regular conversion overrun flag
  [then]


  [ifdef] SDADC_JCHGR_DEF
    \
    \ @brief injected channel group selection register
    \ Address offset: 0x14
    \ Reset value: 0x00000001
    \
    $00 constant SDADC_JCHG                     \ [0x00 : 9] Injected channel group selection
  [then]


  [ifdef] SDADC_CONF0R_DEF
    \
    \ @brief configuration 0 register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_OFFSET0                  \ [0x00 : 12] Twelve-bit calibration offset for configuration 0
    $14 constant SDADC_GAIN0                    \ [0x14 : 3] Gain setting for configuration 0
    $1a constant SDADC_SE0                      \ [0x1a : 2] Single-ended mode for configuration 0
    $1e constant SDADC_COMMON0                  \ [0x1e : 2] Common mode for configuration 0
  [then]


  [ifdef] SDADC_CONF1R_DEF
    \
    \ @brief configuration 1 register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_OFFSET1                  \ [0x00 : 12] Twelve-bit calibration offset for configuration 1
    $14 constant SDADC_GAIN1                    \ [0x14 : 3] Gain setting for configuration 1
    $1a constant SDADC_SE1                      \ [0x1a : 2] Single-ended mode for configuration 1
    $1e constant SDADC_COMMON1                  \ [0x1e : 2] Common mode for configuration 1
  [then]


  [ifdef] SDADC_CONF2R_DEF
    \
    \ @brief configuration 2 register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_OFFSET2                  \ [0x00 : 12] Twelve-bit calibration offset for configuration 2
    $14 constant SDADC_GAIN2                    \ [0x14 : 3] Gain setting for configuration 2
    $1a constant SDADC_SE2                      \ [0x1a : 2] Single-ended mode for configuration 2
    $1e constant SDADC_COMMON2                  \ [0x1e : 2] Common mode for configuration 2
  [then]


  [ifdef] SDADC_CONFCHR1_DEF
    \
    \ @brief channel configuration register 1
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_CONFCH0                  \ [0x00 : 2] CONFCH0
    $04 constant SDADC_CONFCH1                  \ [0x04 : 2] CONFCH1
    $08 constant SDADC_CONFCH2                  \ [0x08 : 2] CONFCH2
    $0c constant SDADC_CONFCH3                  \ [0x0c : 2] CONFCH3
    $10 constant SDADC_CONFCH4                  \ [0x10 : 2] CONFCH4
    $14 constant SDADC_CONFCH5                  \ [0x14 : 2] CONFCH5
    $18 constant SDADC_CONFCH6                  \ [0x18 : 2] CONFCH6
    $1c constant SDADC_CONFCH7                  \ [0x1c : 2] CONFCH7
  [then]


  [ifdef] SDADC_CONFCHR2_DEF
    \
    \ @brief channel configuration register 2
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_CONFCH8                  \ [0x00 : 2] Channel 8 configuration
  [then]


  [ifdef] SDADC_JDATAR_DEF
    \
    \ @brief data register for injected group
    \ Address offset: 0x60
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_JDATA                    \ [0x00 : 16] Injected group conversion data
    $19 constant SDADC_JDATACH                  \ [0x19 : 4] Injected channel most recently converted
  [then]


  [ifdef] SDADC_RDATAR_DEF
    \
    \ @brief data register for the regular channel
    \ Address offset: 0x64
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_RDATA                    \ [0x00 : 16] Regular channel conversion data
  [then]


  [ifdef] SDADC_JDATA12R_DEF
    \
    \ @brief SDADC1 and SDADC2 injected data register
    \ Address offset: 0x70
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_JDATA1                   \ [0x00 : 16] Injected group conversion data for SDADC1
    $10 constant SDADC_JDATA2                   \ [0x10 : 16] Injected group conversion data for SDADC2
  [then]


  [ifdef] SDADC_RDATA12R_DEF
    \
    \ @brief SDADC1 and SDADC2 regular data register
    \ Address offset: 0x74
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_RDATA1                   \ [0x00 : 16] Regular conversion data for SDADC1
    $10 constant SDADC_RDATA2                   \ [0x10 : 16] Regular conversion data for SDADC2
  [then]


  [ifdef] SDADC_JDATA13R_DEF
    \
    \ @brief SDADC1 and SDADC3 injected data register
    \ Address offset: 0x78
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_JDATA1                   \ [0x00 : 16] Injected group conversion data for SDADC1
    $10 constant SDADC_JDATA3                   \ [0x10 : 16] Injected group conversion data for SDADC3
  [then]


  [ifdef] SDADC_RDATA13R_DEF
    \
    \ @brief SDADC1 and SDADC3 regular data register
    \ Address offset: 0x7C
    \ Reset value: 0x00000000
    \
    $00 constant SDADC_RDATA1                   \ [0x00 : 16] Regular conversion data for SDADC1
    $10 constant SDADC_RDATA3                   \ [0x10 : 16] Regular conversion data for SDADC3
  [then]

  \
  \ @brief Sigma-delta analog-to-digital converter
  \
  $00 constant SDADC_CR1                \ control register 1
  $04 constant SDADC_CR2                \ control register 2
  $08 constant SDADC_ISR                \ interrupt and status register
  $0C constant SDADC_CLRISR             \ interrupt and status clear register
  $14 constant SDADC_JCHGR              \ injected channel group selection register
  $20 constant SDADC_CONF0R             \ configuration 0 register
  $24 constant SDADC_CONF1R             \ configuration 1 register
  $28 constant SDADC_CONF2R             \ configuration 2 register
  $40 constant SDADC_CONFCHR1           \ channel configuration register 1
  $44 constant SDADC_CONFCHR2           \ channel configuration register 2
  $60 constant SDADC_JDATAR             \ data register for injected group
  $64 constant SDADC_RDATAR             \ data register for the regular channel
  $70 constant SDADC_JDATA12R           \ SDADC1 and SDADC2 injected data register
  $74 constant SDADC_RDATA12R           \ SDADC1 and SDADC2 regular data register
  $78 constant SDADC_JDATA13R           \ SDADC1 and SDADC3 injected data register
  $7C constant SDADC_RDATA13R           \ SDADC1 and SDADC3 regular data register

: SDADC_DEF ; [then]
