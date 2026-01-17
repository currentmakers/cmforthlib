\
\ @file lptim.fs
\ @brief Low power timer
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] LPTIM_DEF

  [ifdef] LPTIM_LPTIM_ISR_DEF
    \
    \ @brief Interrupt and Status Register
    \ Address offset: 0x00
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPM                     \ [0x00] Compare match The CMPM bit is set by hardware to inform application that LPTIM_CNT register value reached the LPTIM_CMP register's value.
    $01 constant LPTIM_ARRM                     \ [0x01] Autoreload match ARRM is set by hardware to inform application that LPTIM_CNT register's value reached the LPTIM_ARR register's value. ARRM flag can be cleared by writing 1 to the ARRMCF bit in the LPTIM_ICR register.
    $02 constant LPTIM_EXTTRIG                  \ [0x02] External trigger edge event EXTTRIG is set by hardware to inform application that a valid edge on the selected external trigger input has occurred. If the trigger is ignored because the timer has already started, then this flag is not set. EXTTRIG flag can be cleared by writing 1 to the EXTTRIGCF bit in the LPTIM_ICR register.
    $03 constant LPTIM_CMPOK                    \ [0x03] Compare register update OK CMPOK is set by hardware to inform application that the APB bus write operation to the LPTIM_CMP register has been successfully completed.
    $04 constant LPTIM_ARROK                    \ [0x04] Autoreload register update OK ARROK is set by hardware to inform application that the APB bus write operation to the LPTIM_ARR register has been successfully completed. ARROK flag can be cleared by writing 1 to the ARROKCF bit in the LPTIM_ICR register.
    $05 constant LPTIM_UP                       \ [0x05] Counter direction change down to up In Encoder mode, UP bit is set by hardware to inform application that the counter direction has changed from down to up. UP flag can be cleared by writing 1 to the UPCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWN                     \ [0x06] Counter direction change up to down In Encoder mode, DOWN bit is set by hardware to inform application that the counter direction has changed from up to down. DOWN flag can be cleared by writing 1 to the DOWNCF bit in the LPTIM_ICR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_ICR_DEF
    \
    \ @brief Interrupt Clear Register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMCF                   \ [0x00] Compare match clear flag Writing 1 to this bit clears the CMP flag in the LPTIM_ISR register
    $01 constant LPTIM_ARRMCF                   \ [0x01] Autoreload match clear flag Writing 1 to this bit clears the ARRM flag in the LPTIM_ISR register
    $02 constant LPTIM_EXTTRIGCF                \ [0x02] External trigger valid edge clear flag Writing 1 to this bit clears the EXTTRIG flag in the LPTIM_ISR register
    $03 constant LPTIM_CMPOKCF                  \ [0x03] Compare register update OK clear flag Writing 1 to this bit clears the CMPOK flag in the LPTIM_ISR register
    $04 constant LPTIM_ARROKCF                  \ [0x04] Autoreload register update OK clear flag Writing 1 to this bit clears the ARROK flag in the LPTIM_ISR register
    $05 constant LPTIM_UPCF                     \ [0x05] Direction change to UP clear flag Writing 1 to this bit clear the UP flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNCF                   \ [0x06] Direction change to down clear flag Writing 1 to this bit clear the DOWN flag in the LPTIM_ISR register. Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_IER_DEF
    \
    \ @brief Interrupt Enable Register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMPMIE                   \ [0x00] Compare match Interrupt Enable
    $01 constant LPTIM_ARRMIE                   \ [0x01] Autoreload match Interrupt Enable
    $02 constant LPTIM_EXTTRIGIE                \ [0x02] External trigger valid edge Interrupt Enable
    $03 constant LPTIM_CMPOKIE                  \ [0x03] Compare register update OK Interrupt Enable
    $04 constant LPTIM_ARROKIE                  \ [0x04] Autoreload register update OK Interrupt Enable
    $05 constant LPTIM_UPIE                     \ [0x05] Direction change to UP Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
    $06 constant LPTIM_DOWNIE                   \ [0x06] Direction change to down Interrupt Enable Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_CFGR_DEF
    \
    \ @brief Configuration Register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CKSEL                    \ [0x00] Clock selector The CKSEL bit selects which clock source the LPTIM will use:
    $01 constant LPTIM_CKPOL                    \ [0x01 : 2] Clock Polarity If LPTIM is clocked by an external clock source: When the LPTIM is clocked by an external clock source, CKPOL bits is used to configure the active edge or edges used by the counter: If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 1 is active. If the LPTIM is configured in Encoder mode (ENC bit is set), the encoder sub-mode 2 is active. Refer to for more details about Encoder mode sub-modes.
    $03 constant LPTIM_CKFLT                    \ [0x03 : 2] Configurable digital filter for external clock The CKFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an external clock signal before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $06 constant LPTIM_TRGFLT                   \ [0x06 : 2] Configurable digital filter for trigger The TRGFLT value sets the number of consecutive equal samples that should be detected when a level change occurs on an internal trigger before it is considered as a valid level transition. An internal clock source must be present to use this feature
    $09 constant LPTIM_PRESC                    \ [0x09 : 3] Clock prescaler The PRESC bits configure the prescaler division factor. It can be one among the following division factors:
    $0d constant LPTIM_TRIGSEL                  \ [0x0d : 3] Trigger selector The TRIGSEL bits select the trigger source that will serve as a trigger event for the LPTIM among the below 8 available sources: See for details.
    $11 constant LPTIM_TRIGEN                   \ [0x11 : 2] Trigger enable and polarity The TRIGEN bits controls whether the LPTIM counter is started by an external trigger or not. If the external trigger option is selected, three configurations are possible for the trigger active edge:
    $13 constant LPTIM_TIMOUT                   \ [0x13] Timeout enable The TIMOUT bit controls the Timeout feature
    $14 constant LPTIM_WAVE                     \ [0x14] Waveform shape The WAVE bit controls the output shape
    $15 constant LPTIM_WAVPOL                   \ [0x15] Waveform shape polarity The WAVEPOL bit controls the output polarity
    $16 constant LPTIM_PRELOAD                  \ [0x16] Registers update mode The PRELOAD bit controls the LPTIM_ARR and the LPTIM_CMP registers update modality
    $17 constant LPTIM_COUNTMODE                \ [0x17] counter mode enabled The COUNTMODE bit selects which clock source is used by the LPTIM to clock the counter:
    $18 constant LPTIM_ENC                      \ [0x18] Encoder mode enable The ENC bit controls the Encoder mode Note: If the LPTIM does not support encoder mode feature, this bit is reserved. Please refer to .
  [then]


  [ifdef] LPTIM_LPTIM_CR_DEF
    \
    \ @brief Control Register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_ENABLE                   \ [0x00] LPTIM enable The ENABLE bit is set and cleared by software.
    $01 constant LPTIM_SNGSTRT                  \ [0x01] LPTIM start in Single mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in single pulse mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the LPTIM in single pulse mode as soon as an external trigger is detected. If this bit is set when the LPTIM is in continuous counting mode, then the LPTIM will stop at the following match between LPTIM_ARR and LPTIM_CNT registers. This bit can only be set when the LPTIM is enabled. It will be automatically reset by hardware.
    $02 constant LPTIM_CNTSTRT                  \ [0x02] Timer start in Continuous mode This bit is set by software and cleared by hardware. In case of software start (TRIGEN[1:0] = '00'), setting this bit starts the LPTIM in Continuous mode. If the software start is disabled (TRIGEN[1:0] different than '00'), setting this bit starts the timer in Continuous mode as soon as an external trigger is detected. If this bit is set when a single pulse mode counting is ongoing, then the timer will not stop at the next match between the LPTIM_ARR and LPTIM_CNT registers and the LPTIM counter keeps counting in Continuous mode. This bit can be set only when the LPTIM is enabled. It will be automatically reset by hardware.
    $03 constant LPTIM_COUNTRST                 \ [0x03] Counter reset This bit is set by software and cleared by hardware. When set to '1' this bit will trigger a synchronous reset of the LPTIM_CNT counter register. Due to the synchronous nature of this reset, it only takes place after a synchronization delay of 3 LPTimer core clock cycles (LPTimer core clock may be different from APB clock). COUNTRST must never be set to '1' by software before it is already cleared to '0' by hardware. Software should consequently check that COUNTRST bit is already cleared to '0' before attempting to set it to '1'.
    $04 constant LPTIM_RSTARE                   \ [0x04] Reset after read enable This bit is set and cleared by software. When RSTARE is set to '1', any read access to LPTIM_CNT register will asynchronously reset LPTIM_CNT register content.
  [then]


  [ifdef] LPTIM_LPTIM_CMP_DEF
    \
    \ @brief Compare Register
    \ Address offset: 0x14
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CMP                      \ [0x00 : 16] Compare value
  [then]


  [ifdef] LPTIM_LPTIM_ARR_DEF
    \
    \ @brief Autoreload Register
    \ Address offset: 0x18
    \ Reset value: 0x00000001
    \
    $00 constant LPTIM_ARR                      \ [0x00 : 16] Auto reload value
  [then]


  [ifdef] LPTIM_LPTIM_CNT_DEF
    \
    \ @brief Counter Register
    \ Address offset: 0x1C
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_CNT                      \ [0x00 : 16] Counter value
  [then]


  [ifdef] LPTIM_LPTIM_CFGR2_DEF
    \
    \ @brief LPTIM configuration register 2
    \ Address offset: 0x24
    \ Reset value: 0x00000000
    \
    $00 constant LPTIM_IN1SEL                   \ [0x00 : 2] LPTIM input 1 selection The IN1SEL bits control the LPTIM Input 1 multiplexer, which connects LPTIM Input 1 to one of the available inputs. For connection details refer to .
    $04 constant LPTIM_IN2SEL                   \ [0x04 : 2] LPTIM input 2 selection The IN2SEL bits control the LPTIM Input 2 multiplexer, which connect LPTIM Input 2 to one of the available inputs. For connection details refer to . Note: If the LPTIM does not support encoder mode feature, these bits are reserved. Please refer to .
  [then]

  \
  \ @brief Low power timer
  \
  $00 constant LPTIM_LPTIM_ISR          \ Interrupt and Status Register
  $04 constant LPTIM_LPTIM_ICR          \ Interrupt Clear Register
  $08 constant LPTIM_LPTIM_IER          \ Interrupt Enable Register
  $0C constant LPTIM_LPTIM_CFGR         \ Configuration Register
  $10 constant LPTIM_LPTIM_CR           \ Control Register
  $14 constant LPTIM_LPTIM_CMP          \ Compare Register
  $18 constant LPTIM_LPTIM_ARR          \ Autoreload Register
  $1C constant LPTIM_LPTIM_CNT          \ Counter Register
  $24 constant LPTIM_LPTIM_CFGR2        \ LPTIM configuration register 2

: LPTIM_DEF ; [then]
