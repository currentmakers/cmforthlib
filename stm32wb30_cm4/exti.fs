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
    \ @brief rising trigger selection register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_RT                        \ [0x00 : 22] Rising trigger event configuration bit of Configurable Event input
    $1f constant EXTI_RT_31                     \ [0x1f] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR1_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_FT                        \ [0x00 : 22] Falling trigger event configuration bit of Configurable Event input
    $1f constant EXTI_FT_31                     \ [0x1f] Falling trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER1_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_SWI                       \ [0x00 : 22] Software interrupt on event
    $1f constant EXTI_SWI_31                    \ [0x1f] Software interrupt on event
  [then]


  [ifdef] EXTI_PR1_DEF
    \
    \ @brief EXTI pending register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_PIF                       \ [0x00 : 22] Configurable event inputs Pending bit
    $1f constant EXTI_PIF_31                    \ [0x1f] Configurable event inputs Pending bit
  [then]


  [ifdef] EXTI_RTSR2_DEF
    \
    \ @brief rising trigger selection register
    \ Address offset: 0x20
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_RT33                      \ [0x01] Rising trigger event configuration bit of Configurable Event input
    $08 constant EXTI_RT40_41                   \ [0x08 : 2] Rising trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_FTSR2_DEF
    \
    \ @brief falling trigger selection register
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_FT33                      \ [0x01] Falling trigger event configuration bit of Configurable Event input
    $08 constant EXTI_FT40_41                   \ [0x08 : 2] Falling trigger event configuration bit of Configurable Event input
  [then]


  [ifdef] EXTI_SWIER2_DEF
    \
    \ @brief software interrupt event register
    \ Address offset: 0x28
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_SWI33                     \ [0x01] Software interrupt on event
    $08 constant EXTI_SWI40_41                  \ [0x08 : 2] Software interrupt on event
  [then]


  [ifdef] EXTI_PR2_DEF
    \
    \ @brief pending register
    \ Address offset: 0x2C
    \ Reset value: 0x00000000
    \
    $01 constant EXTI_PIF33                     \ [0x01] Configurable event inputs x+32 Pending bit.
    $08 constant EXTI_PIF40_41                  \ [0x08 : 2] Configurable event inputs x+32 Pending bit.
  [then]


  [ifdef] EXTI_C1IMR1_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0x80
    \ Reset value: 0x7FC00000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] CPU(m) wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C1EMR1_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0x84
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0_15                    \ [0x00 : 16] CPU(m) Wakeup with event generation Mask on Event input
    $11 constant EXTI_EM17_21                   \ [0x11 : 5] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_C1IMR2_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0x90
    \ Reset value: 0x0001FCFD
    \
    $00 constant EXTI_IM                        \ [0x00 : 17] CPUm Wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C1EMR2_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0x94
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM                        \ [0x08 : 2] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_C2IMR1_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0xC0
    \ Reset value: 0x7FC00000
    \
    $00 constant EXTI_IM                        \ [0x00 : 32] CPU(m) wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C2EMR1_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0xC4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EM0_15                    \ [0x00 : 16] CPU(m) Wakeup with event generation Mask on Event input
    $11 constant EXTI_EM17_21                   \ [0x11 : 5] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_C2IMR2_DEF
    \
    \ @brief CPUm wakeup with interrupt mask register
    \ Address offset: 0xD0
    \ Reset value: 0x0001FCFD
    \
    $00 constant EXTI_IM                        \ [0x00 : 17] CPUm Wakeup with interrupt Mask on Event input
  [then]


  [ifdef] EXTI_C2EMR2_DEF
    \
    \ @brief CPUm wakeup with event mask register
    \ Address offset: 0xD4
    \ Reset value: 0x00000000
    \
    $08 constant EXTI_EM                        \ [0x08 : 2] CPU(m) Wakeup with event generation Mask on Event input
  [then]


  [ifdef] EXTI_HWCFGR7_DEF
    \
    \ @brief EXTI Hardware configuration registers
    \ Address offset: 0x3D8
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] HW configuration CPU event generation
  [then]


  [ifdef] EXTI_HWCFGR6_DEF
    \
    \ @brief Hardware configuration registers
    \ Address offset: 0x3DC
    \ Reset value: 0x00000300
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] HW configuration CPU event generation
  [then]


  [ifdef] EXTI_HWCFGR5_DEF
    \
    \ @brief Hardware configuration registers
    \ Address offset: 0x3E0
    \ Reset value: 0x003EFFFF
    \
    $00 constant EXTI_CPUEVENT                  \ [0x00 : 32] HW configuration CPU event generation
  [then]


  [ifdef] EXTI_HWCFGR4_DEF
    \
    \ @brief Hardware configuration registers
    \ Address offset: 0x3E4
    \ Reset value: 0x00000000
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] HW configuration event trigger type
  [then]


  [ifdef] EXTI_HWCFGR3_DEF
    \
    \ @brief Hardware configuration registers
    \ Address offset: 0x3E8
    \ Reset value: 0x00000302
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] HW configuration event trigger type
  [then]


  [ifdef] EXTI_HWCFGR2_DEF
    \
    \ @brief Hardware configuration registers
    \ Address offset: 0x3EC
    \ Reset value: 0x803FFFFF
    \
    $00 constant EXTI_EVENT_TRG                 \ [0x00 : 32] HW configuration event trigger type
  [then]


  [ifdef] EXTI_HWCFGR1_DEF
    \
    \ @brief Hardware configuration register 1
    \ Address offset: 0x3F0
    \ Reset value: 0x00003130
    \
    $00 constant EXTI_NBEVENTS                  \ [0x00 : 8] HW configuration number of event
    $08 constant EXTI_NBCPUS                    \ [0x08 : 4] HW configuration number of CPUs
    $0c constant EXTI_CPUEVTEN                  \ [0x0c : 4] HW configuration of CPU(m) event output enable
  [then]


  [ifdef] EXTI_VERR_DEF
    \
    \ @brief EXTI IP Version register
    \ Address offset: 0x3F4
    \ Reset value: 0x00000020
    \
    $00 constant EXTI_MINREV                    \ [0x00 : 4] Minor Revision number
    $04 constant EXTI_MAJREV                    \ [0x04 : 4] Major Revision number
  [then]


  [ifdef] EXTI_IPIDR_DEF
    \
    \ @brief Identification register
    \ Address offset: 0x3F8
    \ Reset value: 0x000E0001
    \
    $00 constant EXTI_IPID                      \ [0x00 : 32] IP Identification
  [then]


  [ifdef] EXTI_SIDR_DEF
    \
    \ @brief Size ID register
    \ Address offset: 0x3FC
    \ Reset value: 0xA3C5DD01
    \
    $00 constant EXTI_SID                       \ [0x00 : 32] Size Identification
  [then]

  \
  \ @brief External interrupt/event controller
  \
  $00 constant EXTI_RTSR1               \ rising trigger selection register
  $04 constant EXTI_FTSR1               \ falling trigger selection register
  $08 constant EXTI_SWIER1              \ software interrupt event register
  $0C constant EXTI_PR1                 \ EXTI pending register
  $20 constant EXTI_RTSR2               \ rising trigger selection register
  $24 constant EXTI_FTSR2               \ falling trigger selection register
  $28 constant EXTI_SWIER2              \ software interrupt event register
  $2C constant EXTI_PR2                 \ pending register
  $80 constant EXTI_C1IMR1              \ CPUm wakeup with interrupt mask register
  $84 constant EXTI_C1EMR1              \ CPUm wakeup with event mask register
  $90 constant EXTI_C1IMR2              \ CPUm wakeup with interrupt mask register
  $94 constant EXTI_C1EMR2              \ CPUm wakeup with event mask register
  $C0 constant EXTI_C2IMR1              \ CPUm wakeup with interrupt mask register
  $C4 constant EXTI_C2EMR1              \ CPUm wakeup with event mask register
  $D0 constant EXTI_C2IMR2              \ CPUm wakeup with interrupt mask register
  $D4 constant EXTI_C2EMR2              \ CPUm wakeup with event mask register
  $3D8 constant EXTI_HWCFGR7            \ EXTI Hardware configuration registers
  $3DC constant EXTI_HWCFGR6            \ Hardware configuration registers
  $3E0 constant EXTI_HWCFGR5            \ Hardware configuration registers
  $3E4 constant EXTI_HWCFGR4            \ Hardware configuration registers
  $3E8 constant EXTI_HWCFGR3            \ Hardware configuration registers
  $3EC constant EXTI_HWCFGR2            \ Hardware configuration registers
  $3F0 constant EXTI_HWCFGR1            \ Hardware configuration register 1
  $3F4 constant EXTI_VERR               \ EXTI IP Version register
  $3F8 constant EXTI_IPIDR              \ Identification register
  $3FC constant EXTI_SIDR               \ Size ID register

: EXTI_DEF ; [then]
