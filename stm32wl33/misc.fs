\
\ @file misc.fs
\ @brief RFIP_VERSION register
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

[ifndef] MISC_DEF

  [ifdef] MISC_RFIP_VERSION_DEF
    \
    \ @brief RFIP_VERSION register
    \ Address offset: 0x00
    \ Reset value: 0x00001200
    \
    $04 constant MISC_REVISION                  \ [0x04 : 4] Revision of the MR_SubG (to be used for metal fixes)
    $08 constant MISC_VERSION                   \ [0x08 : 4] Version of the MR_SubG (to be used for cut upgrades)
    $0c constant MISC_PRODUCT                   \ [0x0c : 4] Used for major upgrades (new protocols support / new features)
  [then]


  [ifdef] MISC_RRM_UDRA_CTRL_DEF
    \
    \ @brief RRM_UDRA_CTRL register
    \ Address offset: 0x04
    \ Reset value: 0x00000000
    \
    $00 constant MISC_RRM_CMD_REQ               \ [0x00] Action bit: write 1 to request a RRM-UDRA command.
  [then]


  [ifdef] MISC_SEQUENCER_CTRL_DEF
    \
    \ @brief SEQUENCER_CTRL register
    \ Address offset: 0x08
    \ Reset value: 0x00000000
    \
    $00 constant MISC_GEN_SEQ_TRIGGER           \ [0x00] Action bit: write 1 to generate a trigger event on Sequencer.
    $01 constant MISC_DISABLE_SEQ               \ [0x01] Enable/disable the Sequencer
  [then]


  [ifdef] MISC_ABSOLUTE_TIME_DEF
    \
    \ @brief ABSOLUTE_TIME register
    \ Address offset: 0x0C
    \ Reset value: 0x00000000
    \
    $00 constant MISC_ABSOLUTE_TIME             \ [0x00 : 32] Indicate the interpolated absolute.
  [then]


  [ifdef] MISC_SCM_COUNTER_VAL_DEF
    \
    \ @brief SCM_COUNTER_VAL register
    \ Address offset: 0x10
    \ Reset value: 0x00000000
    \
    $00 constant MISC_SCM_COUNTER_CURRVAL       \ [0x00 : 15] Slow Clock Measurement: number of 16 MHz clock cycles contained in 32 slow clock periods.
  [then]


  [ifdef] MISC_SCM_MIN_MAX_DEF
    \
    \ @brief SCM_MIN_MAX register
    \ Address offset: 0x14
    \ Reset value: 0x00007FFF
    \
    $00 constant MISC_SCM_COUNTER_MINVAL        \ [0x00 : 15] Slow Clock Measurement: minimum SCM_COUNTER value seen since the counter is ON and since last clear request.
    $10 constant MISC_SCM_COUNTER_MAXVAL        \ [0x10 : 15] Slow Clock Measurement: maximum SCM_COUNTER value seen since the counter is ON and since last clear request.
    $1f constant MISC_CLEAR_MIN_MAX             \ [0x1f] Write 1' to clear the SCM_COUNTER_MINVAL and SCM_COUNTER_MAXVAL bit fields.
  [then]


  [ifdef] MISC_WAKEUP_IRQ_STATUS_DEF
    \
    \ @brief WAKEUP_IRQ_STATUS register
    \ Address offset: 0x18
    \ Reset value: 0x00000000
    \
    $00 constant MISC_CPU_WAKEUP_F              \ [0x00] Set when the interpolated absolute time matches the CPU_WAKEUPTIME while WAKEUP_CTRL.
    $01 constant MISC_RFIP_WAKEUP_F             \ [0x01] Set when the interpolated absolute time matches the RFIP_WAKEUPTIME while WAKEUP_CTRL.
  [then]

  \
  \ @brief RFIP_VERSION register
  \
  $00 constant MISC_RFIP_VERSION        \ RFIP_VERSION register
  $04 constant MISC_RRM_UDRA_CTRL       \ RRM_UDRA_CTRL register
  $08 constant MISC_SEQUENCER_CTRL      \ SEQUENCER_CTRL register
  $0C constant MISC_ABSOLUTE_TIME       \ ABSOLUTE_TIME register
  $10 constant MISC_SCM_COUNTER_VAL     \ SCM_COUNTER_VAL register
  $14 constant MISC_SCM_MIN_MAX         \ SCM_MIN_MAX register
  $18 constant MISC_WAKEUP_IRQ_STATUS   \ WAKEUP_IRQ_STATUS register

: MISC_DEF ; [then]
