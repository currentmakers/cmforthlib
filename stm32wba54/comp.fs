\
\ @file comp.fs
\ @brief Comparator
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] COMP_DEF

  [ifdef] COMP_COMP1_CSR_DEF
    \
    \ @brief COMP1 control and status register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] COMP1 enable
    $04 constant COMP_INMSEL                    \ [0x04 : 4] COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
    $08 constant COMP_INPSEL                    \ [0x08 : 3] COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
    $0b constant COMP_WINMODE                   \ [0x0b] COMP1 noninverting input selector for window mode Controlled by software (if not locked), selects the signal for the COMP1_INP input of the COMP1.
    $0e constant COMP_WINOUT                    \ [0x0e] COMP1 output selector Controlled by software (if not locked), selects the COMP1 output.
    $0f constant COMP_POLARITY                  \ [0x0f] COMP1 polarity selector Controlled by software (if not locked), selects the COMP1 output polarity
    $10 constant COMP_HYST                      \ [0x10 : 2] COMP1 hysteresis selector Controlled by software (if not locked), selects the COMP1 hysteresis.
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] COMP1 power mode selector Controlled by software (if not locked), selects the power consumption and, as a consequence, the speed of the COMP1.
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] COMP1 blanking source selector.
    $1e constant COMP_VALUE                     \ [0x1e] COMP1 output status.
    $1f constant COMP_LOCK                      \ [0x1f] COMP1_CSR register lock.
  [then]


  [ifdef] COMP_COMP2_CSR_DEF
    \
    \ @brief COMP2 control and status register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant COMP_EN                        \ [0x00] COMP1 enable
    $04 constant COMP_INMSEL                    \ [0x04 : 4] COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
    $08 constant COMP_INPSEL                    \ [0x08 : 2] COMP1 signal selector for inverting input INM Controlled by software (if not locked), selects the signal for the inverting input COMP1_INM
    $0b constant COMP_WINMODE                   \ [0x0b] COMP1 noninverting input selector for window mode Controlled by software (if not locked), selects the signal for the COMP1_INP input of the COMP1.
    $0e constant COMP_WINOUT                    \ [0x0e] COMP1 output selector Controlled by software (if not locked), selects the COMP1 output.
    $0f constant COMP_POLARITY                  \ [0x0f] COMP1 polarity selector Controlled by software (if not locked), selects the COMP1 output polarity
    $10 constant COMP_HYST                      \ [0x10 : 2] COMP1 hysteresis selector Controlled by software (if not locked), selects the COMP1 hysteresis.
    $12 constant COMP_PWRMODE                   \ [0x12 : 2] COMP1 power mode selector Controlled by software (if not locked), selects the power consumption and, as a consequence, the speed of the COMP1.
    $14 constant COMP_BLANKSEL                  \ [0x14 : 5] COMP1 blanking source selector.
    $1e constant COMP_VALUE                     \ [0x1e] COMP1 output status.
    $1f constant COMP_LOCK                      \ [0x1f] COMP1_CSR register lock.
  [then]

  \
  \ @brief Comparator
  \
  $00 constant COMP_COMP1_CSR           \ COMP1 control and status register
  $04 constant COMP_COMP2_CSR           \ COMP2 control and status register

: COMP_DEF ; [then]
