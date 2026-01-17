\
\ @file exti.fs
\ @brief External interrupt/event controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] EXTI_DEF

  [ifdef] EXTI_RTSR1_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration bit of Configurable Event input
    $11 constant EXTI_TR17                      \ [0x11] Rising trigger event configuration bit of Configurable Event input
    $12 constant EXTI_TR18                      \ [0x12] Rising trigger event configuration bit of Configurable Event input
    $13 constant EXTI_TR19                      \ [0x13] Rising trigger event configuration bit of Configurable Event input
    $14 constant EXTI_TR20                      \ [0x14] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_TR21                      \ [0x15] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_TR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_TR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_TR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_TR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_TR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_TR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_TR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_TR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_TR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_TR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_TR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_TR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_TR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_TR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_TR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_TR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_TR16                      \ [0x10] Rising trigger event configuration bit of Configurable Event input
    $11 constant EXTI_TR17                      \ [0x11] Rising trigger event configuration bit of Configurable Event input
    $12 constant EXTI_TR18                      \ [0x12] Rising trigger event configuration bit of Configurable Event input
    $13 constant EXTI_TR19                      \ [0x13] Rising trigger event configuration bit of Configurable Event input
    $14 constant EXTI_TR20                      \ [0x14] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_TR21                      \ [0x15] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWIER0                    \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_SWIER1                    \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_SWIER2                    \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_SWIER3                    \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_SWIER4                    \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_SWIER5                    \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_SWIER6                    \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_SWIER7                    \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_SWIER8                    \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_SWIER9                    \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_SWIER10                   \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_SWIER11                   \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_SWIER12                   \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_SWIER13                   \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_SWIER14                   \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_SWIER15                   \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_SWIER16                   \ [0x10] Rising trigger event configuration bit of Configurable Event input
    $11 constant EXTI_SWIER17                   \ [0x11] Rising trigger event configuration bit of Configurable Event input
    $12 constant EXTI_SWIER18                   \ [0x12] Rising trigger event configuration bit of Configurable Event input
    $13 constant EXTI_SWIER19                   \ [0x13] Rising trigger event configuration bit of Configurable Event input
    $14 constant EXTI_SWIER20                   \ [0x14] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_SWIER21                   \ [0x15] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_D3PMR1_DEF
    \
    \ @brief EXTI D3 pending mask register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_MR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_MR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_MR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_MR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_MR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_MR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_MR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_MR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_MR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_MR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_MR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_MR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_MR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_MR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_MR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $13 constant EXTI_MR19                      \ [0x13] Rising trigger event configuration bit of Configurable Event input
    $14 constant EXTI_MR20                      \ [0x14] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_MR21                      \ [0x15] Rising trigger event configuration bit of Configurable Event input
    $19 constant EXTI_MR25                      \ [0x19] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_D3PCR1L_DEF
    \
    \ @brief EXTI D3 pending clear selection register low
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PCS0                      \ [0x00 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $02 constant EXTI_PCS1                      \ [0x02 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $04 constant EXTI_PCS2                      \ [0x04 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $06 constant EXTI_PCS3                      \ [0x06 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $08 constant EXTI_PCS4                      \ [0x08 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $0a constant EXTI_PCS5                      \ [0x0a : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $0c constant EXTI_PCS6                      \ [0x0c : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $0e constant EXTI_PCS7                      \ [0x0e : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $10 constant EXTI_PCS8                      \ [0x10 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $12 constant EXTI_PCS9                      \ [0x12 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $14 constant EXTI_PCS10                     \ [0x14 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $16 constant EXTI_PCS11                     \ [0x16 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $18 constant EXTI_PCS12                     \ [0x18 : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $1a constant EXTI_PCS13                     \ [0x1a : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $1c constant EXTI_PCS14                     \ [0x1c : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
    $1e constant EXTI_PCS15                     \ [0x1e : 2] D3 Pending request clear input signal selection on Event input x = truncate (n/2)
  [then]


  [ifdef] EXTI_D3PCR1H_DEF
    \
    \ @brief EXTI D3 pending clear selection register high
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $06 constant EXTI_PCS19                     \ [0x06 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
    $08 constant EXTI_PCS20                     \ [0x08 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
    $0a constant EXTI_PCS21                     \ [0x0a : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
    $12 constant EXTI_PCS25                     \ [0x12 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+32)/2)
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $11 constant EXTI_TR49                      \ [0x11] Rising trigger event configuration bit of Configurable Event input x+32
    $13 constant EXTI_TR51                      \ [0x13] Rising trigger event configuration bit of Configurable Event input x+32
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $11 constant EXTI_TR49                      \ [0x11] Falling trigger event configuration bit of Configurable Event input x+32
    $13 constant EXTI_TR51                      \ [0x13] Falling trigger event configuration bit of Configurable Event input x+32
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $11 constant EXTI_SWIER49                   \ [0x11] Software interrupt on line x+32
    $13 constant EXTI_SWIER51                   \ [0x13] Software interrupt on line x+32
  [then]


  [ifdef] EXTI_D3PMR2_DEF
    \
    \ @brief EXTI D3 pending mask register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $02 constant EXTI_MR34                      \ [0x02] D3 Pending Mask on Event input x+32
    $03 constant EXTI_MR35                      \ [0x03] D3 Pending Mask on Event input x+32
    $09 constant EXTI_MR41                      \ [0x09] D3 Pending Mask on Event input x+32
    $10 constant EXTI_MR48                      \ [0x10] D3 Pending Mask on Event input x+32
    $11 constant EXTI_MR49                      \ [0x11] D3 Pending Mask on Event input x+32
    $12 constant EXTI_MR50                      \ [0x12] D3 Pending Mask on Event input x+32
    $13 constant EXTI_MR51                      \ [0x13] D3 Pending Mask on Event input x+32
    $14 constant EXTI_MR52                      \ [0x14] D3 Pending Mask on Event input x+32
    $15 constant EXTI_MR53                      \ [0x15] D3 Pending Mask on Event input x+32
  [then]


  [ifdef] EXTI_D3PCR2L_DEF
    \
    \ @brief EXTI D3 pending clear selection register low
    \ Address offset: 0x30
    \ Reset value: 0x00000000
    \
    $04 constant EXTI_PCS34                     \ [0x04 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)
    $06 constant EXTI_PCS35                     \ [0x06 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)
    $12 constant EXTI_PCS41                     \ [0x12 : 2] D3 Pending request clear input signal selection on Event input x = truncate ((n+64)/2)
  [then]


  [ifdef] EXTI_D3PCR2H_DEF
    \
    \ @brief EXTI D3 pending clear selection register high
    \ Address offset: 0x34
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PCS48                     \ [0x00 : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
    $02 constant EXTI_PCS49                     \ [0x02 : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
    $04 constant EXTI_PCS50                     \ [0x04 : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
    $06 constant EXTI_PCS51                     \ [0x06 : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
    $08 constant EXTI_PCS52                     \ [0x08 : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
    $0a constant EXTI_PCS53                     \ [0x0a : 2] Pending request clear input signal selection on Event input x= truncate ((n+96)/2)
  [then]


  [ifdef] EXTI_RTSR3_DEF
    \
    \ @brief EXTI rising trigger selection register
    \ Address offset: 0x40
    \ Reset value: 0x00000000
    \
    $12 constant EXTI_TR82                      \ [0x12] Rising trigger event configuration bit of Configurable Event input x+64
    $14 constant EXTI_TR84                      \ [0x14] Rising trigger event configuration bit of Configurable Event input x+64
    $15 constant EXTI_TR85                      \ [0x15] Rising trigger event configuration bit of Configurable Event input x+64
    $16 constant EXTI_TR86                      \ [0x16] Rising trigger event configuration bit of Configurable Event input x+64
  [then]


  [ifdef] EXTI_FTSR3_DEF
    \
    \ @brief EXTI falling trigger selection register
    \ Address offset: 0x44
    \ Reset value: 0x00000000
    \
    $12 constant EXTI_TR82                      \ [0x12] Falling trigger event configuration bit of Configurable Event input x+64
    $14 constant EXTI_TR84                      \ [0x14] Falling trigger event configuration bit of Configurable Event input x+64
    $15 constant EXTI_TR85                      \ [0x15] Falling trigger event configuration bit of Configurable Event input x+64
    $16 constant EXTI_TR86                      \ [0x16] Falling trigger event configuration bit of Configurable Event input x+64
  [then]


  [ifdef] EXTI_SWIER3_DEF
    \
    \ @brief EXTI software interrupt event register
    \ Address offset: 0x48
    \ Reset value: 0x00000000
    \
    $12 constant EXTI_SWIER82                   \ [0x12] Software interrupt on line x+64
    $14 constant EXTI_SWIER84                   \ [0x14] Software interrupt on line x+64
    $15 constant EXTI_SWIER85                   \ [0x15] Software interrupt on line x+64
    $16 constant EXTI_SWIER86                   \ [0x16] Software interrupt on line x+64
  [then]


  [ifdef] EXTI_D3PMR3_DEF
    \
    \ @brief EXTI D3 pending mask register
    \ Address offset: 0x4C
    \ Reset value: 0x00000000
    \
    $18 constant EXTI_MR88                      \ [0x18] D3 Pending Mask on Event input x+64
  [then]


  [ifdef] EXTI_D3PCR3H_DEF
    \
    \ @brief EXTI D3 pending clear selection register high
    \ Address offset: 0x54
    \ Reset value: 0x00000000
    \
    $12 constant EXTI_PCS88                     \ [0x12 : 2] D3 Pending request clear input signal selection on Event input x= truncate N+160/2
  [then]


  [ifdef] EXTI_CPUIMR1_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0xFFC00000
    \
    $00 constant EXTI_MR0                       \ [0x00] Rising trigger event configuration bit of Configurable Event input
    $01 constant EXTI_MR1                       \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $02 constant EXTI_MR2                       \ [0x02] Rising trigger event configuration bit of Configurable Event input
    $03 constant EXTI_MR3                       \ [0x03] Rising trigger event configuration bit of Configurable Event input
    $04 constant EXTI_MR4                       \ [0x04] Rising trigger event configuration bit of Configurable Event input
    $05 constant EXTI_MR5                       \ [0x05] Rising trigger event configuration bit of Configurable Event input
    $06 constant EXTI_MR6                       \ [0x06] Rising trigger event configuration bit of Configurable Event input
    $07 constant EXTI_MR7                       \ [0x07] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_MR8                       \ [0x08] Rising trigger event configuration bit of Configurable Event input
    $09 constant EXTI_MR9                       \ [0x09] Rising trigger event configuration bit of Configurable Event input
    $0a constant EXTI_MR10                      \ [0x0a] Rising trigger event configuration bit of Configurable Event input
    $0b constant EXTI_MR11                      \ [0x0b] Rising trigger event configuration bit of Configurable Event input
    $0c constant EXTI_MR12                      \ [0x0c] Rising trigger event configuration bit of Configurable Event input
    $0d constant EXTI_MR13                      \ [0x0d] Rising trigger event configuration bit of Configurable Event input
    $0e constant EXTI_MR14                      \ [0x0e] Rising trigger event configuration bit of Configurable Event input
    $0f constant EXTI_MR15                      \ [0x0f] Rising trigger event configuration bit of Configurable Event input
    $10 constant EXTI_MR16                      \ [0x10] Rising trigger event configuration bit of Configurable Event input
    $11 constant EXTI_MR17                      \ [0x11] Rising trigger event configuration bit of Configurable Event input
    $12 constant EXTI_MR18                      \ [0x12] Rising trigger event configuration bit of Configurable Event input
    $13 constant EXTI_MR19                      \ [0x13] Rising trigger event configuration bit of Configurable Event input
    $14 constant EXTI_MR20                      \ [0x14] Rising trigger event configuration bit of Configurable Event input
    $15 constant EXTI_MR21                      \ [0x15] Rising trigger event configuration bit of Configurable Event input
    $16 constant EXTI_MR22                      \ [0x16] Rising trigger event configuration bit of Configurable Event input
    $17 constant EXTI_MR23                      \ [0x17] Rising trigger event configuration bit of Configurable Event input
    $18 constant EXTI_MR24                      \ [0x18] Rising trigger event configuration bit of Configurable Event input
    $19 constant EXTI_MR25                      \ [0x19] Rising trigger event configuration bit of Configurable Event input
    $1a constant EXTI_MR26                      \ [0x1a] Rising trigger event configuration bit of Configurable Event input
    $1b constant EXTI_MR27                      \ [0x1b] Rising trigger event configuration bit of Configurable Event input
    $1c constant EXTI_MR28                      \ [0x1c] Rising trigger event configuration bit of Configurable Event input
    $1d constant EXTI_MR29                      \ [0x1d] Rising trigger event configuration bit of Configurable Event input
    $1e constant EXTI_MR30                      \ [0x1e] Rising trigger event configuration bit of Configurable Event input
    $1f constant EXTI_MR31                      \ [0x1f] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_CPUEMR1_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] CPU Event mask on Event input x
    $01 constant EXTI_MR1                       \ [0x01] CPU Event mask on Event input x
    $02 constant EXTI_MR2                       \ [0x02] CPU Event mask on Event input x
    $03 constant EXTI_MR3                       \ [0x03] CPU Event mask on Event input x
    $04 constant EXTI_MR4                       \ [0x04] CPU Event mask on Event input x
    $05 constant EXTI_MR5                       \ [0x05] CPU Event mask on Event input x
    $06 constant EXTI_MR6                       \ [0x06] CPU Event mask on Event input x
    $07 constant EXTI_MR7                       \ [0x07] CPU Event mask on Event input x
    $08 constant EXTI_MR8                       \ [0x08] CPU Event mask on Event input x
    $09 constant EXTI_MR9                       \ [0x09] CPU Event mask on Event input x
    $0a constant EXTI_MR10                      \ [0x0a] CPU Event mask on Event input x
    $0b constant EXTI_MR11                      \ [0x0b] CPU Event mask on Event input x
    $0c constant EXTI_MR12                      \ [0x0c] CPU Event mask on Event input x
    $0d constant EXTI_MR13                      \ [0x0d] CPU Event mask on Event input x
    $0e constant EXTI_MR14                      \ [0x0e] CPU Event mask on Event input x
    $0f constant EXTI_MR15                      \ [0x0f] CPU Event mask on Event input x
    $10 constant EXTI_MR16                      \ [0x10] CPU Event mask on Event input x
    $11 constant EXTI_MR17                      \ [0x11] CPU Event mask on Event input x
    $12 constant EXTI_MR18                      \ [0x12] CPU Event mask on Event input x
    $13 constant EXTI_MR19                      \ [0x13] CPU Event mask on Event input x
    $14 constant EXTI_MR20                      \ [0x14] CPU Event mask on Event input x
    $15 constant EXTI_MR21                      \ [0x15] CPU Event mask on Event input x
    $16 constant EXTI_MR22                      \ [0x16] CPU Event mask on Event input x
    $17 constant EXTI_MR23                      \ [0x17] CPU Event mask on Event input x
    $18 constant EXTI_MR24                      \ [0x18] CPU Event mask on Event input x
    $19 constant EXTI_MR25                      \ [0x19] CPU Event mask on Event input x
    $1a constant EXTI_MR26                      \ [0x1a] CPU Event mask on Event input x
    $1b constant EXTI_MR27                      \ [0x1b] CPU Event mask on Event input x
    $1c constant EXTI_MR28                      \ [0x1c] CPU Event mask on Event input x
    $1d constant EXTI_MR29                      \ [0x1d] CPU Event mask on Event input x
    $1e constant EXTI_MR30                      \ [0x1e] CPU Event mask on Event input x
    $1f constant EXTI_MR31                      \ [0x1f] CPU Event mask on Event input x
  [then]


  [ifdef] EXTI_CPUPR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x88
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PR0                       \ [0x00] CPU Event mask on Event input x
    $01 constant EXTI_PR1                       \ [0x01] CPU Event mask on Event input x
    $02 constant EXTI_PR2                       \ [0x02] CPU Event mask on Event input x
    $03 constant EXTI_PR3                       \ [0x03] CPU Event mask on Event input x
    $04 constant EXTI_PR4                       \ [0x04] CPU Event mask on Event input x
    $05 constant EXTI_PR5                       \ [0x05] CPU Event mask on Event input x
    $06 constant EXTI_PR6                       \ [0x06] CPU Event mask on Event input x
    $07 constant EXTI_PR7                       \ [0x07] CPU Event mask on Event input x
    $08 constant EXTI_PR8                       \ [0x08] CPU Event mask on Event input x
    $09 constant EXTI_PR9                       \ [0x09] CPU Event mask on Event input x
    $0a constant EXTI_PR10                      \ [0x0a] CPU Event mask on Event input x
    $0b constant EXTI_PR11                      \ [0x0b] CPU Event mask on Event input x
    $0c constant EXTI_PR12                      \ [0x0c] CPU Event mask on Event input x
    $0d constant EXTI_PR13                      \ [0x0d] CPU Event mask on Event input x
    $0e constant EXTI_PR14                      \ [0x0e] CPU Event mask on Event input x
    $0f constant EXTI_PR15                      \ [0x0f] CPU Event mask on Event input x
    $10 constant EXTI_PR16                      \ [0x10] CPU Event mask on Event input x
    $11 constant EXTI_PR17                      \ [0x11] CPU Event mask on Event input x
    $12 constant EXTI_PR18                      \ [0x12] CPU Event mask on Event input x
    $13 constant EXTI_PR19                      \ [0x13] CPU Event mask on Event input x
    $14 constant EXTI_PR20                      \ [0x14] CPU Event mask on Event input x
    $15 constant EXTI_PR21                      \ [0x15] CPU Event mask on Event input x
  [then]


  [ifdef] EXTI_CPUIMR2_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR0                       \ [0x00] CPU Interrupt Mask on Direct Event input x+32
    $01 constant EXTI_MR1                       \ [0x01] CPU Interrupt Mask on Direct Event input x+32
    $02 constant EXTI_MR2                       \ [0x02] CPU Interrupt Mask on Direct Event input x+32
    $03 constant EXTI_MR3                       \ [0x03] CPU Interrupt Mask on Direct Event input x+32
    $04 constant EXTI_MR4                       \ [0x04] CPU Interrupt Mask on Direct Event input x+32
    $05 constant EXTI_MR5                       \ [0x05] CPU Interrupt Mask on Direct Event input x+32
    $06 constant EXTI_MR6                       \ [0x06] CPU Interrupt Mask on Direct Event input x+32
    $07 constant EXTI_MR7                       \ [0x07] CPU Interrupt Mask on Direct Event input x+32
    $08 constant EXTI_MR8                       \ [0x08] CPU Interrupt Mask on Direct Event input x+32
    $09 constant EXTI_MR9                       \ [0x09] CPU Interrupt Mask on Direct Event input x+32
    $0a constant EXTI_MR10                      \ [0x0a] CPU Interrupt Mask on Direct Event input x+32
    $0b constant EXTI_MR11                      \ [0x0b] CPU Interrupt Mask on Direct Event input x+32
    $0c constant EXTI_MR12                      \ [0x0c] CPU Interrupt Mask on Direct Event input x+32
    $0e constant EXTI_MR14                      \ [0x0e] CPU Interrupt Mask on Direct Event input x+32
    $0f constant EXTI_MR15                      \ [0x0f] CPU Interrupt Mask on Direct Event input x+32
    $10 constant EXTI_MR16                      \ [0x10] CPU Interrupt Mask on Direct Event input x+32
    $11 constant EXTI_MR17                      \ [0x11] CPU Interrupt Mask on Direct Event input x+32
    $12 constant EXTI_MR18                      \ [0x12] CPU Interrupt Mask on Direct Event input x+32
    $13 constant EXTI_MR19                      \ [0x13] CPU Interrupt Mask on Direct Event input x+32
    $14 constant EXTI_MR20                      \ [0x14] CPU Interrupt Mask on Direct Event input x+32
    $15 constant EXTI_MR21                      \ [0x15] CPU Interrupt Mask on Direct Event input x+32
    $16 constant EXTI_MR22                      \ [0x16] CPU Interrupt Mask on Direct Event input x+32
    $17 constant EXTI_MR23                      \ [0x17] CPU Interrupt Mask on Direct Event input x+32
    $18 constant EXTI_MR24                      \ [0x18] CPU Interrupt Mask on Direct Event input x+32
    $19 constant EXTI_MR25                      \ [0x19] CPU Interrupt Mask on Direct Event input x+32
    $1a constant EXTI_MR26                      \ [0x1a] CPU Interrupt Mask on Direct Event input x+32
    $1b constant EXTI_MR27                      \ [0x1b] CPU Interrupt Mask on Direct Event input x+32
    $1c constant EXTI_MR28                      \ [0x1c] CPU Interrupt Mask on Direct Event input x+32
    $1d constant EXTI_MR29                      \ [0x1d] CPU Interrupt Mask on Direct Event input x+32
    $1e constant EXTI_MR30                      \ [0x1e] CPU Interrupt Mask on Direct Event input x+32
    $1f constant EXTI_MR31                      \ [0x1f] CPU Interrupt Mask on Direct Event input x+32
  [then]


  [ifdef] EXTI_CPUEMR2_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR32                      \ [0x00] CPU Interrupt Mask on Direct Event input x+32
    $01 constant EXTI_MR33                      \ [0x01] CPU Interrupt Mask on Direct Event input x+32
    $02 constant EXTI_MR34                      \ [0x02] CPU Interrupt Mask on Direct Event input x+32
    $03 constant EXTI_MR35                      \ [0x03] CPU Interrupt Mask on Direct Event input x+32
    $04 constant EXTI_MR36                      \ [0x04] CPU Interrupt Mask on Direct Event input x+32
    $05 constant EXTI_MR37                      \ [0x05] CPU Interrupt Mask on Direct Event input x+32
    $06 constant EXTI_MR38                      \ [0x06] CPU Interrupt Mask on Direct Event input x+32
    $07 constant EXTI_MR39                      \ [0x07] CPU Interrupt Mask on Direct Event input x+32
    $08 constant EXTI_MR40                      \ [0x08] CPU Interrupt Mask on Direct Event input x+32
    $09 constant EXTI_MR41                      \ [0x09] CPU Interrupt Mask on Direct Event input x+32
    $0a constant EXTI_MR42                      \ [0x0a] CPU Interrupt Mask on Direct Event input x+32
    $0b constant EXTI_MR43                      \ [0x0b] CPU Interrupt Mask on Direct Event input x+32
    $0c constant EXTI_MR44                      \ [0x0c] CPU Interrupt Mask on Direct Event input x+32
    $0e constant EXTI_MR46                      \ [0x0e] CPU Interrupt Mask on Direct Event input x+32
    $0f constant EXTI_MR47                      \ [0x0f] CPU Interrupt Mask on Direct Event input x+32
    $10 constant EXTI_MR48                      \ [0x10] CPU Interrupt Mask on Direct Event input x+32
    $11 constant EXTI_MR49                      \ [0x11] CPU Interrupt Mask on Direct Event input x+32
    $12 constant EXTI_MR50                      \ [0x12] CPU Interrupt Mask on Direct Event input x+32
    $13 constant EXTI_MR51                      \ [0x13] CPU Interrupt Mask on Direct Event input x+32
    $14 constant EXTI_MR52                      \ [0x14] CPU Interrupt Mask on Direct Event input x+32
    $15 constant EXTI_MR53                      \ [0x15] CPU Interrupt Mask on Direct Event input x+32
    $16 constant EXTI_MR54                      \ [0x16] CPU Interrupt Mask on Direct Event input x+32
    $17 constant EXTI_MR55                      \ [0x17] CPU Interrupt Mask on Direct Event input x+32
    $18 constant EXTI_MR56                      \ [0x18] CPU Interrupt Mask on Direct Event input x+32
    $19 constant EXTI_MR57                      \ [0x19] CPU Interrupt Mask on Direct Event input x+32
    $1a constant EXTI_MR58                      \ [0x1a] CPU Interrupt Mask on Direct Event input x+32
    $1b constant EXTI_MR59                      \ [0x1b] CPU Interrupt Mask on Direct Event input x+32
    $1c constant EXTI_MR60                      \ [0x1c] CPU Interrupt Mask on Direct Event input x+32
    $1d constant EXTI_MR61                      \ [0x1d] CPU Interrupt Mask on Direct Event input x+32
    $1e constant EXTI_MR62                      \ [0x1e] CPU Interrupt Mask on Direct Event input x+32
    $1f constant EXTI_MR63                      \ [0x1f] CPU Interrupt Mask on Direct Event input x+32
  [then]


  [ifdef] EXTI_CPUPR2_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x98
    \ Reset value: 0x00000000
    \
    $11 constant EXTI_PR49                      \ [0x11] Configurable event inputs x+32 Pending bit
    $13 constant EXTI_PR51                      \ [0x13] Configurable event inputs x+32 Pending bit
  [then]


  [ifdef] EXTI_CPUIMR3_DEF
    \
    \ @brief EXTI interrupt mask register
    \ Address offset: 0xA0
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR64                      \ [0x00] CPU Interrupt Mask on Direct Event input x+64
    $01 constant EXTI_MR65                      \ [0x01] CPU Interrupt Mask on Direct Event input x+64
    $02 constant EXTI_MR66                      \ [0x02] CPU Interrupt Mask on Direct Event input x+64
    $03 constant EXTI_MR67                      \ [0x03] CPU Interrupt Mask on Direct Event input x+64
    $04 constant EXTI_MR68                      \ [0x04] CPU Interrupt Mask on Direct Event input x+64
    $05 constant EXTI_MR69                      \ [0x05] CPU Interrupt Mask on Direct Event input x+64
    $06 constant EXTI_MR70                      \ [0x06] CPU Interrupt Mask on Direct Event input x+64
    $07 constant EXTI_MR71                      \ [0x07] CPU Interrupt Mask on Direct Event input x+64
    $08 constant EXTI_MR72                      \ [0x08] CPU Interrupt Mask on Direct Event input x+64
    $09 constant EXTI_MR73                      \ [0x09] CPU Interrupt Mask on Direct Event input x+64
    $0a constant EXTI_MR74                      \ [0x0a] CPU Interrupt Mask on Direct Event input x+64
    $0b constant EXTI_MR75                      \ [0x0b] CPU Interrupt Mask on Direct Event input x+64
    $0c constant EXTI_MR76                      \ [0x0c] CPU Interrupt Mask on Direct Event input x+64
    $0d constant EXTI_MR77                      \ [0x0d] CPU Interrupt Mask on Direct Event input x+64
    $0e constant EXTI_MR78                      \ [0x0e] CPU Interrupt Mask on Direct Event input x+64
    $0f constant EXTI_MR79                      \ [0x0f] CPU Interrupt Mask on Direct Event input x+64
    $10 constant EXTI_MR80                      \ [0x10] CPU Interrupt Mask on Direct Event input x+64
    $12 constant EXTI_MR82                      \ [0x12] CPU Interrupt Mask on Direct Event input x+64
    $14 constant EXTI_MR84                      \ [0x14] CPU Interrupt Mask on Direct Event input x+64
    $15 constant EXTI_MR85                      \ [0x15] CPU Interrupt Mask on Direct Event input x+64
    $16 constant EXTI_MR86                      \ [0x16] CPU Interrupt Mask on Direct Event input x+64
    $17 constant EXTI_MR87                      \ [0x17] CPU Interrupt Mask on Direct Event input x+64
    $18 constant EXTI_MR88                      \ [0x18] CPU Interrupt Mask on Direct Event input x+64
  [then]


  [ifdef] EXTI_CPUEMR3_DEF
    \
    \ @brief EXTI event mask register
    \ Address offset: 0xA4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_MR64                      \ [0x00] CPU Event mask on Event input x+64
    $01 constant EXTI_MR65                      \ [0x01] CPU Event mask on Event input x+64
    $02 constant EXTI_MR66                      \ [0x02] CPU Event mask on Event input x+64
    $03 constant EXTI_MR67                      \ [0x03] CPU Event mask on Event input x+64
    $04 constant EXTI_MR68                      \ [0x04] CPU Event mask on Event input x+64
    $05 constant EXTI_MR69                      \ [0x05] CPU Event mask on Event input x+64
    $06 constant EXTI_MR70                      \ [0x06] CPU Event mask on Event input x+64
    $07 constant EXTI_MR71                      \ [0x07] CPU Event mask on Event input x+64
    $08 constant EXTI_MR72                      \ [0x08] CPU Event mask on Event input x+64
    $09 constant EXTI_MR73                      \ [0x09] CPU Event mask on Event input x+64
    $0a constant EXTI_MR74                      \ [0x0a] CPU Event mask on Event input x+64
    $0b constant EXTI_MR75                      \ [0x0b] CPU Event mask on Event input x+64
    $0c constant EXTI_MR76                      \ [0x0c] CPU Event mask on Event input x+64
    $0d constant EXTI_MR77                      \ [0x0d] CPU Event mask on Event input x+64
    $0e constant EXTI_MR78                      \ [0x0e] CPU Event mask on Event input x+64
    $0f constant EXTI_MR79                      \ [0x0f] CPU Event mask on Event input x+64
    $10 constant EXTI_MR80                      \ [0x10] CPU Event mask on Event input x+64
    $12 constant EXTI_MR82                      \ [0x12] CPU Event mask on Event input x+64
    $14 constant EXTI_MR84                      \ [0x14] CPU Event mask on Event input x+64
    $15 constant EXTI_MR85                      \ [0x15] CPU Event mask on Event input x+64
    $16 constant EXTI_MR86                      \ [0x16] CPU Event mask on Event input x+64
    $17 constant EXTI_MR87                      \ [0x17] CPU Event mask on Event input x+64
    $18 constant EXTI_MR88                      \ [0x18] CPU Event mask on Event input x+64
  [then]


  [ifdef] EXTI_CPUPR3_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0xA8
    \ Reset value: 0x00000000
    \
    $12 constant EXTI_PR82                      \ [0x12] Configurable event inputs x+64 Pending bit
    $14 constant EXTI_PR84                      \ [0x14] Configurable event inputs x+64 Pending bit
    $15 constant EXTI_PR85                      \ [0x15] Configurable event inputs x+64 Pending bit
    $16 constant EXTI_PR86                      \ [0x16] Configurable event inputs x+64 Pending bit
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ EXTI rising trigger selection register
  $04 constant EXTI_FTSR1               \ EXTI falling trigger selection register
  $08 constant EXTI_SWIER1              \ EXTI software interrupt event register
  $0C constant EXTI_D3PMR1              \ EXTI D3 pending mask register
  $10 constant EXTI_D3PCR1L             \ EXTI D3 pending clear selection register low
  $14 constant EXTI_D3PCR1H             \ EXTI D3 pending clear selection register high
  $20 constant EXTI_RTSR2               \ EXTI rising trigger selection register
  $24 constant EXTI_FTSR2               \ EXTI falling trigger selection register
  $28 constant EXTI_SWIER2              \ EXTI software interrupt event register
  $2C constant EXTI_D3PMR2              \ EXTI D3 pending mask register
  $30 constant EXTI_D3PCR2L             \ EXTI D3 pending clear selection register low
  $34 constant EXTI_D3PCR2H             \ EXTI D3 pending clear selection register high
  $40 constant EXTI_RTSR3               \ EXTI rising trigger selection register
  $44 constant EXTI_FTSR3               \ EXTI falling trigger selection register
  $48 constant EXTI_SWIER3              \ EXTI software interrupt event register
  $4C constant EXTI_D3PMR3              \ EXTI D3 pending mask register
  $54 constant EXTI_D3PCR3H             \ EXTI D3 pending clear selection register high
  $80 constant EXTI_CPUIMR1             \ EXTI interrupt mask register
  $84 constant EXTI_CPUEMR1             \ EXTI event mask register
  $88 constant EXTI_CPUPR1              \ EXTI pending register
  $90 constant EXTI_CPUIMR2             \ EXTI interrupt mask register
  $94 constant EXTI_CPUEMR2             \ EXTI event mask register
  $98 constant EXTI_CPUPR2              \ EXTI pending register
  $A0 constant EXTI_CPUIMR3             \ EXTI interrupt mask register
  $A4 constant EXTI_CPUEMR3             \ EXTI event mask register
  $A8 constant EXTI_CPUPR3              \ EXTI pending register

: EXTI_DEF ; [then]
